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
                list.Add(reader[0].ToString());
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
                result += $"ул. {reader[0]} {reader[1]}";

            return result;
        }
    }
}
