using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    static class Privilege
    {
        public enum Position
        {
            Administrator,
            Cashier,
            Accountant
        }

        public static void AddUser( string login, string password, Position position)
        {
            var conn = ConnectToMySQL.GetDBConnection();
            conn.Open();

            string sql = "INSERT INTO users (login, password, position) " +
                        $"VALUES ('{login}', '{password}', ";
            switch (position)
            {
                case Position.Administrator:
                    sql += "'админ');";
                    break;
                case Position.Cashier:
                    sql += "'кассир');";
                    break;
                case Position.Accountant:
                    sql += "'бухгалтер');";
                    break;
            }

            MySqlCommand command = new MySqlCommand(sql, conn);     // объект для выполнения SQL-запроса
            command.ExecuteNonQuery();
            conn.Close();
        }
        public static void DeleteUser(string user_name)
        {
            MySqlConnection conn = ConnectToMySQL.GetDBConnection();
            conn.Open();

            string sql = $"DROP USER '{user_name}';";
            MySqlCommand command = new MySqlCommand(sql, conn);     // объект для выполнения SQL-запроса
            command.ExecuteNonQuery();

            conn.Close();
        }

        public static bool UserExist(MySqlConnection conn, string login, string password)
        {
            string sql = $"SELECT check_user_existence('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, conn); 
            return (bool)command.ExecuteScalar();
        }
    }
}
