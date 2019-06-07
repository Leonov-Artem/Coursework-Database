using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class Get
    {
        public string[] InfoAboutFilms()
        {
            string sql = "SELECT film_name, producer, year_of_issue FROM films;";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
            {
                string info = СonvertFirstCharacterToUpperCase(reader[0].ToString()) + $" ({reader[1]}, {reader[2]})";
                list.Add(info);
            }
            reader.Close();

            return list.ToArray();
        }
        static public void FilmNameProdecerYear(string film_description, out string film_name, out string producer, out string year)
        {
            film_name = "";
            producer = "";
            year = "";
        }
    }
}
