using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace serialGenerator
{
    internal class Connect
    {
        public MySqlConnection connection;

        string db;
        string srv;
        string usr;
        string pass;

        string connectionstring;

        public Connect()
        {
            srv = "localhost";
            db = "serial";
            usr = "root";
            pass = "";
            connectionstring = "SERVER=" + srv + ";" + "DATABASE=" + db+";" + "UID=" + usr + ";" + "PASSWORD=" + pass + ";" + "SslMode=None;";

            connection=new MySqlConnection(connectionstring);

            try
            {
                connection.Open();
                Console.WriteLine("Sikeres kapcsolódás");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

            

    }
}
