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
        public static bool DeleteUser(MySqlConnection conn, string login, string password)
        {
            string sql = $"SELECT delete_user('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, conn);
            return (bool)command.ExecuteScalar();
        }
        public static bool UserExist(MySqlConnection conn, string login, string password)
        {
            string sql = $"SELECT check_user_existence('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, conn); 
            return (bool)command.ExecuteScalar();
        }
        public static Position GetUserPosition(MySqlConnection conn, string login, string password)
        {
            string sql = $"SELECT get_user_position('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, conn);
            string pos = command.ExecuteScalar().ToString();
            
            switch(pos)
            {
                case "админ": return Position.Administrator;
                case "кассир": return Position.Cashier;
                case "бухгалтер": return Position.Accountant;
            }

            throw new Exception("Пользователь не найден!");
        }
    }
}
