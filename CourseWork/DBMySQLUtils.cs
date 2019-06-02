using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    class DBMySQLUtils
    {
        public static MySqlConnection GetDBConnection(string host, string username, string database, string password)
        {
            // Connection String.
            string connString = "server=" + host + ";database=" + database
                               + ";user=" + username + ";password=" + password;

            return new MySqlConnection(connString);
        }
    }
}