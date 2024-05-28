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


        public void insertBySql(String sql)
        {
            MySqlCommand com = new MySqlCommand(sql, dbconnect);
            com.ExecuteNonQuery();
        }

        public void insert(String table, String[] data)
        {

            String sql = $"INSERT INTO {table} VALUE (";
            for (int i = 0; i < data.Length; i++)
            {
                if (i == data.Length - 1)
                {
                    sql += "\"" + data[i] + "\"" + ");";
                }
                else
                {
                    sql += "\"" + data[i] + "\"" + ",";
                }
            }
            insertBySql(sql);

            //insert("OrderItem", new string[] { "202405240901000002", "C10435", "10", "12.3" });

        }

        //not done
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

        public MySqlDataReader readWhere(String table, String condition)
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

    }


}
