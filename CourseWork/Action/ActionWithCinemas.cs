using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    partial class Action
    {
        public bool DeleteCinema(string cinema_name, string address_id)
        {
            string sql = $"select delete_cinema('{cinema_name.ToLower()}', {address_id});";
            return (bool)Command(sql).ExecuteScalar();
        }
        public bool AddNewCinema(string cinema_name, string category, string street, string house)
        {
            string sql = $"SELECT add_new_cinema('{cinema_name}', {category}, '{street}', '{house}');";
            return (bool)Command(sql).ExecuteScalar();
        }
        public void UpdateCinema(string cinema_id, string address_id, string new_name, string new_category, string new_street, string new_house)
        {
            string sql = $"CALL update_cinema({cinema_id}, {address_id}, '{new_name}', {new_category}, '{new_street}', '{new_house}');";
            Command(sql).ExecuteNonQuery();
        }
    }
}
