using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class Get
    {
        public string[] Cinemas()
        {
            string sql = $"SELECT name FROM movie_theaters;";
            MySqlDataReader reader = Command(sql).ExecuteReader();

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
            return Command(sql).ExecuteScalar().ToString();
        }
        public string CinemaId(string cinema_decription)
        {
            NameAndCinemaAddress(cinema_decription, out string cinema_name, out string street, out string house);
            string address_id = AddressId(street, house);
            string category = CinemaCategory(cinema_name, address_id);

            return CinemaId(cinema_name, category, address_id);
        }

        public string CinemaCategory(string name, string addressID)
        {
            string sql = $"SELECT get_cinema_category('{name}', {addressID})";
            return Command(sql).ExecuteScalar().ToString();
        }
        public string CinemaCategory(string cinema_decription)
        {
            NameAndCinemaAddress(cinema_decription, out string cinema_name, out string street, out string house);
            string address_id = AddressId(street, house);
            return CinemaCategory(cinema_name, address_id);
        }

        public string CurrnetHallsNumber(string cinema_id)
        {
            string sql = $"select get_current_number_halls ({cinema_id})";
            return Command(sql).ExecuteScalar().ToString();
        }

        static public void NameAndCinemaAddress(string cinema_decription, out string name, out string street, out string house)
        {
            name = GetCinemaName(cinema_decription);
            street = GetStreet(cinema_decription);
            house = GetHouseNumber(cinema_decription);
        }
        
        public string[] CinemasWithAddresses()
        {
            string[] cinemas = Cinemas();
            List<string> list = new List<string>();

            foreach (var cinema in cinemas)
                list.Add(cinema + " (" + Address(cinema.ToLower()) + ")");

            return list.ToArray();
        }

        static private string GetCinemaName(string cinema_decription)
        {
            string name = GetValue(cinema_decription, @"^(.+)\s+\(");
            return SplitAndJoin(name);
        }
        static private string GetStreet(string cinema_decription)
        {
            string street = GetValue(cinema_decription, @"\(.+\.\s+(.+)\,");
            return SplitAndJoin(street);
        }
        static private string GetHouseNumber(string cinema_decription)
            => GetValue(cinema_decription, @",\s+(.+)\)");
    }
}
