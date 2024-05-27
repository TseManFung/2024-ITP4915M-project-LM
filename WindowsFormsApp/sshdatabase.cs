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
    internal class sshdatabase
    {
        SshClient client;
        MySqlConnection dbconnect;
        public sshdatabase()

        {
            this.sshConnect();
            this.dbConnect();
            this.test();
           



        }



        public void test()
        {
            var reader =this.read("SELECT * FROM Category;");
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + " " + reader["Type"]);
                Console.WriteLine(reader.GetString(0) + " " + reader.GetValue(1));
                Console.WriteLine();
            }
        }

        //not done
        public void insert(String sql)
        {
            MySqlCommand com = new MySqlCommand(sql, dbconnect);
            com.ExecuteNonQuery();
        }

        //not done
        public void update(String sql)
        {
            MySqlCommand com = new MySqlCommand(sql, dbconnect);
            com.ExecuteNonQuery();
        }

        public MySqlDataReader read(String sql)
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
