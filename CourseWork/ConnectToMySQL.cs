using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    static class ConnectToMySQL
    {
        public static MySqlConnection GetDBConnection(string database)
        {
            const string host = "localhost";
            const string username = "root";
            const string password = "S5qD4a8X2a84;";

            return GetDBConnection(host, username, database, password);
        }

        private static MySqlConnection GetDBConnection(string host, string username, string database, string password)
        {
            // Connection String.
            string connString = "server=" + host + ";database=" + database
                               + ";user=" + username + ";password=" + password;

            return new MySqlConnection(connString);
        }
    }
}
