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
        public string[] HallsNumbers(string cinema_id)
        {
            string sql = $"call get_halls_numbers({cinema_id});";
            MySqlDataReader reader = Command(sql).ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
                list.Add(reader[0].ToString());
            reader.Close();

            return list.ToArray();
        }
        public string HallCapacity(string cinema_id, string hall_number)
        {
            string slq = $"SELECT get_capacity({cinema_id}, {hall_number});";
            return Command(slq).ExecuteScalar().ToString();
        }
        public string HallId(string cinema_id, string hall_number)
        {
            string sql = $"select get_hall_id({cinema_id}, {hall_number});";
            return Command(sql).ExecuteScalar().ToString();

        }
    }
}
