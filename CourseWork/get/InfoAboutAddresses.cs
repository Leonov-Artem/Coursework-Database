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
    }
}
