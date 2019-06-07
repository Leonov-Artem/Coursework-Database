﻿using System;
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
        public string FilmId(string name, string producer, string year)
        {
            string sql = $"select get_film_id('{name}', '{producer}', '{year}')";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return command.ExecuteScalar().ToString();
        }
        static public void FilmNameProdecerYear(string film_description, out string film_name, out string producer, out string year)
        {
            film_name = GetFilmName(film_description);
            producer = GetProducer(film_description);
            year = GetYear(film_description);
        }
        public void AllInfoAboutFilm(string film_id,out string name,
                                                    out string producer   ,
                                                    out string country    ,
                                                    out string year       ,
                                                    out string genre      ,
                                                    out string duration   ,
                                                    out string description,
                                                    out string actors     )
        {
            string sql = $"call get_all_info_about_film({film_id})";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            string[] decription = GetDescriprion(reader);

            name        = decription[0];
            producer    = decription[1];
            country     = decription[2];
            year        = decription[3];
            genre       = decription[4];
            duration    = decription[5];
            description = decription[6];
            actors      = decription[7];
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
        private string[] GetDescriprion(MySqlDataReader reader)
        {
            string str = "";
            while (reader.Read())
                str += "{" + reader[0].ToString() + "}" +
                      "{" + reader[1].ToString() + "}" +
                      "{" + reader[2].ToString() + "}" +
                      "{" + reader[3].ToString() + "}" +
                      "{" + reader[4].ToString() + "}" +
                      "{" + reader[5].ToString() + "}" +
                      "{" + reader[6].ToString() + "}" +
                      "{" + reader[7].ToString();
            reader.Close();

            return str.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}