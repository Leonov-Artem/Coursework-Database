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

        public static bool AddUser(MySqlConnection conn, string login, string password, Position position)
        {
            string sql = $"SELECT add_new_user('{login}', '{password}', ";

            switch(position)
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
            return (bool)command.ExecuteScalar();
        }
        public static void DeleteUser(string user_name)
        {
            
        }
        public static bool UserExist(MySqlConnection conn, string login, string password)
        {
            string sql = $"SELECT check_user_existence('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, conn); 
            return (bool)command.ExecuteScalar();
        }
    }
}
