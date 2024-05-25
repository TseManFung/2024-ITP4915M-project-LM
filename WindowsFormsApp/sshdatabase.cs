using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Renci.SshNet;

namespace WindowsFormsApp
{
    internal class sshdatabase
    {
        public sshdatabase()

        {

            using (var client = new SshClient("192.9.149.106", 22, "mysqluser", "P@$$w0rd")) // establishing ssh connection to server where MySql is hosted
            {
                client.Connect();
                if (client.IsConnected)
                {
                    var portForwarded = new ForwardedPortLocal("127.0.0.1", 3306, "127.0.0.1", 3306);
                    client.AddForwardedPort(portForwarded);
                    portForwarded.Start();
                    using (MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;uid=mysqluser;pwd=P@$$w0rd;database=test;"))
                    {
                        con.Open();
                        using (MySqlCommand com = new MySqlCommand("SELECT * FROM Category;", con))
                        {
                            using (MySqlDataReader reader = com.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine(reader[0] + " " + reader[1]);
                                }
                            }
                        }
                    }
                    client.Disconnect();
                }
                else
                {
                    Console.WriteLine("Client cannot be reached...");
                }
            }

        }
    }

}
