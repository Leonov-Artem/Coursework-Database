using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    partial class Action
    {
        public bool DeleteFIlm(string film_name, string producer, string year)
        {
            string sql = $"select delete_film('{film_name}', '{producer}', '{year}');";
            return (bool)Command(sql).ExecuteScalar();
        }
        public void UpdateFilm(string film_id,
                               string name,
                               string new_prod,
                               string new_country,
                               string new_year,
                               string new_genre,
                               string new_duration,
                               string new_description,
                               string new_actors)
        {
            string sql = $"call update_film({film_id}," +
                $"'{name}'," +
                $"'{new_prod}'," +
                $"'{new_country}'," +
                $"'{new_year}'," +
                $"'{new_genre}'," +
                $"'{new_duration}'," +
                $"'{new_description}'," +
                $"'{new_actors}');";
            Command(sql).ExecuteNonQuery();
        }
        public void AddNewFilm(string name,
                               string producer,
                               string country,
                               string year,
                               string genre,
                               string duration,
                               string description,
                               string actors)
        {
            string sql = $"CALL add_new_film('{name}'," +
                $"'{producer}'," +
                $"'{country}'," +
                $"'{year}'," +
                $"'{genre}'," +
                $"'{duration}'," +
                $"'{description}'," +
                $"'{actors}'" +
                $");";
            Command(sql).ExecuteNonQuery();
        }
    }
}
