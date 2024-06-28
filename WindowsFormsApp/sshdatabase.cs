using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
using Renci.SshNet;
using MySqlConnector;
using System.Data.Common;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp
{
    public class sshdatabase
    {
        SshClient client;
        MySqlConnection dbconnect;
        public sshdatabase()

        {
            this.sshConnect();
            this.dbConnect();
        }

        public MySqlConnection get_dbconnect()
        {
            return dbconnect;
        }

        // debug
        public void ShowDataTable(DataTable dt)
        {
            Console.WriteLine("DataTable:");
            Console.WriteLine("-----------------");
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    Console.Write($"{col.ColumnName}: {row[col]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------");
        }


        public void insertBySql(String sql)
        {
            MySqlCommand com = new MySqlCommand(sql, dbconnect);
            com.ExecuteNonQuery();
        }

        public void insert(String table, params object[] data)
        {
            String sql = $"INSERT INTO `{table}` VALUES (";
            for (int i = 0; i < data.Length; i++)
            {
                sql += $"\"{data[i]}\"";
                if (i != data.Length - 1)
                {
                    sql += ",";
                }
            }
            sql += ");";
            insertBySql(sql);
        }


        public bool updateBySql(String sql)
        {
            try
            {
                MySqlCommand com = new MySqlCommand(sql, dbconnect);
                com.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool update(String table, String[] field, String[] data, String condition)
        {
            if (field.Length != data.Length)
            {
                return false;
            }
            String sql = $"UPDATE {table} SET ";
            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                {
                    sql += $"{field[i]}={data[i]} ";
                }
                else
                {
                    sql += $"{field[i]}={data[i]},";
                }
            }
            sql += $"WHERE {condition};";
            return updateBySql(sql);
        }

        public string ComputeSha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public int getUserID(string loginName, string pw)
        {
            string sql = "SELECT `UserID`,`LoginName` FROM `User` WHERE `LoginName` = @loginName AND `Password` = @pw";
            int count = 0;
            int id = -1;
            string name = "";
            using (MySqlCommand com = new MySqlCommand(sql, dbconnect))
            {

                com.Parameters.AddWithValue("@loginName", loginName);
                com.Parameters.AddWithValue("@pw", "0" + ComputeSha256Hash(pw));

                using (MySqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        count++;
                        id = (int)reader["UserID"];
                        name = (string)reader["LoginName"];

                    }
                }
                com.Parameters.Clear();
            }

            if (count == 1&&(name != "") && (name == loginName))
            {
                return id;
            }
            else
            {
                throw new Exception("No user found with the given login name and password.");
            }

        }
        public MySqlDataReader readBySql(String sql)
        {
            MySqlCommand com = new MySqlCommand(sql, dbconnect);
            MySqlDataReader reader = com.ExecuteReader();
            return reader;
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0] + " " + reader["Type"]);
            //    Console.WriteLine(reader.GetString(0) + " " + reader.GetValue(1));
            //    Console.WriteLine();
            //}
        }

        public MySqlDataReader readAll(String table, String condition)
        {
            String sql = $"SELECT * FROM {table} Where {condition};";
            return this.readBySql(sql);
        }

        public MySqlDataReader readAll(String table)
        {
            String sql = $"SELECT * FROM {table};";
            return this.readBySql(sql);
        }

        public void sshConnect()
        {
            this.sshDisconnect();
            this.client = new SshClient("192.9.149.106", 22, "mysqluser", "P@$$w0rd");
            client.Connect();
            if (client.IsConnected)
            {
                var portForwarded = new ForwardedPortLocal("127.0.0.1", 3306, "127.0.0.1", 3306);
                client.AddForwardedPort(portForwarded);
                portForwarded.Start();
            }
            else
            {
                Console.WriteLine("Client cannot be reached...");
            }
        }

        public void sshDisconnect()
        {
            if (!(this.client is null) && this.client.IsConnected)
            {
                this.client.Disconnect();
            }
        }

        public void dbConnect()
        {
            this.dbDisconnect();
            this.dbconnect = new MySqlConnection("server=127.0.0.1;port=3306;uid=mysqluser;pwd=P@$$w0rd;database=test;");
            dbconnect.Open();
        }

        public void dbDisconnect()
        {
            if (!(this.dbconnect is null) && this.dbconnect.State == ConnectionState.Open)
            {
                this.dbconnect.Close();
            }
        }

        public void closeAll()
        {
            this.sshDisconnect();
            this.dbDisconnect();
        }

        public DataTable getTable(String table)
        {
            String sql = $"SELECT * FROM {table};";
            return this.GetDataTable(sql);
        }

        public DataTable GetDataTable(String sql)
        {
            DataTable dt = new DataTable();
            using (MySqlDataAdapter da = new MySqlDataAdapter(sql, dbconnect))
            {
                da.Fill(dt);
            }
            return dt;
        }


    }


}
