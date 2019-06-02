using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection(string database)
        {
            const string host = "localhost";
            const string username = "root";
            const string password = "S5qD4a8X2a84;";

            return DBMySQLUtils.GetDBConnection(host, username, database, password);
        }
    }
}
