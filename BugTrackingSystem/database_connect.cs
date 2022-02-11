using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BugTrackingSystem
{
    class database_connect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Mysql Database connection
        public MySqlConnection Db_Connect()
        {
            server = "localhost";
            database = "bug_tracking_system";
            uid = "root";
            password = "";
            string connectionstring;
            connectionstring = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionstring);
            connection.Open();

            return connection;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
