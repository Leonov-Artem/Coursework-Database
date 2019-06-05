using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public class Get
    {
        MySqlConnection connection;

        public Get(MySqlConnection connection) => this.connection = connection;

        public string[] Cinemas()
        {
            string sql = $"SELECT name FROM movie_theaters";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
            {
                string name = СonvertFirstCharacterToUpperCase(reader[0].ToString());
                list.Add(name);
            }
            reader.Close();

            return list.ToArray();
        }
        public string Address(string cinema_name)
        {
            string sql = $"call get_address('{cinema_name}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            string result = "";
            while (reader.Read())
            {
                string street_name = СonvertFirstCharacterToUpperCase(reader[0].ToString());
                string house_number = reader[1].ToString();
                result += $"ул. {street_name} {house_number}";
            }
            reader.Close();

            return result;
        }

        private string СonvertFirstCharacterToUpperCase(string word)
            => word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1);
    }
}
