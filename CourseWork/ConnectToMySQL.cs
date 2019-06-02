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
        public static MySqlConnection GetDBConnection(string database="city_cinemas", string host="localhost", string username="root", string password="S5qD4a8X2a84;")
        {
            // Connection String.
            string connString = "server=" + host + ";database=" + database
                               + ";user=" + username + ";password=" + password;

            return new MySqlConnection(connString);
        }
    }
}
