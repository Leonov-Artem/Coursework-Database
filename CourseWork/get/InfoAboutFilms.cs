using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

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
            film_name = GetFilmName(film_description);
            producer = GetProducer(film_description);
            year = GetYear(film_description);
        }

        static private string GetFilmName(string film_description)
        {
            var match = Regex.Match(film_description, @"^(.+)\s+\(");
            string name = match.Groups[1].Value;
            name = SplitAndJoin(name);

            return name;
        }
        static private string GetProducer(string film_description)
        {
            var match = Regex.Match(film_description, @"\s+\((.+)\,");
            string producer = match.Groups[1].Value;
            producer = SplitAndJoin(producer);

            return producer;
        }
        static private string GetYear(string film_description)
        {
            var match = Regex.Match(film_description, @",\s+(.+)\)");
            string year = match.Groups[1].Value;
            year = SplitAndJoin(year);

            return year;
        }
    }
}
