using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            string sql = $"SELECT name FROM movie_theaters;";
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
        public string CinemaId(string name, string category, string address_id)
        {
            string sql = $"SELECT get_cinema_id('{name}', {category}, {address_id});";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return command.ExecuteScalar().ToString();
        }
        public string CinemaCategory(string name, string addressID)
        {
            string sql = $"SELECT get_cinema_category('{name}', {addressID})";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return command.ExecuteScalar().ToString();
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
                result += $"ул. {street_name}, {house_number}";
            }
            reader.Close();

            return result;
        }
        public string AddressId(string street_name, string house_number)
        {
            string sql = $"SELECT get_address_id('{street_name}', '{house_number}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return command.ExecuteScalar().ToString();
        }

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

        static public void NameAndCinemaAddress(string cinema_decription, out string name, out string street, out string house)
        {
            name = GetCinemaName(cinema_decription);
            street = GetStreet(cinema_decription);
            house = GetHouseNumber(cinema_decription);
        }

        //////////////////////PRIVATE//////////////////////////////////////////
        static private string SplitAndJoin(string name)
        {
            string[] split = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            foreach (var s in split)
                result += s + " ";

            return result.Remove(result.Length - 1, 1);
        }
        private string СonvertFirstCharacterToUpperCase(string word)
            => word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1);
        static private string GetCinemaName(string cinema_decription)
        {
            var match = Regex.Match(cinema_decription, @"^(.+)\s+\(");
            string name = match.Groups[1].Value;
            name = SplitAndJoin(name);

            return name;
        }
        static private string GetStreet(string cinema_decription)
        {
            var match = Regex.Match(cinema_decription, @"\(.+\.\s+(.+)\,");
            string street = match.Groups[1].Value;
            street = SplitAndJoin(street);

            return street;
        }
        static private string GetHouseNumber(string cinema_decription)
        {
            var match = Regex.Match(cinema_decription, @",\s+(\w+.+\b)");
            return match.Groups[1].Value;
        }
    }
}
