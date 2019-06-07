﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    class Action
    {
        MySqlConnection connection;

        public Action(MySqlConnection connection) => this.connection = connection;

        public bool DeleteCinema(string cinema_name, string address_id)
        {
            string sql = $"select delete_cinema('{cinema_name.ToLower()}', {address_id});";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return (bool)command.ExecuteScalar();
        }
        public bool DeleteFIlm(string film_name, string producer, string year)
        {
            string sql = $"select delete_film('{film_name}', '{producer}', '{year}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return (bool)command.ExecuteScalar();
        }
        public void DeleteAddress(string id)
        {
            string sql = $"call delete_address({id});";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
        public bool AddNewCinema(string cinema_name, string category, string street, string house)
        {
            string sql = $"SELECT add_new_cinema('{cinema_name}', {category}, '{street}', '{house}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return (bool)command.ExecuteScalar();
        }
        public void UpdateCinema(string cinema_id, string address_id, string new_name, string new_category, string new_street, string new_house)
        {
            string sql = $"CALL update_cinema({cinema_id}, {address_id}, '{new_name}', {new_category}, '{new_street}', '{new_house}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.ExecuteNonQuery();
        }
    }
}
