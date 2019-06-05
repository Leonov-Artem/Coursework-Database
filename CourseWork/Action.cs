using System;
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
    }
}
