using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    partial class Action
    {
        public bool AddNewHall(string cinemaID, string hallNumber, string capacity)
        {
            string sql = $"SELECT add_new_hall({cinemaID}, {hallNumber}, {capacity})";
            return (bool)Command(sql).ExecuteScalar();
        }
        public bool UpdateHall(string cinemaID, string old_hallNumber, string new_capacity)
        {
            string sql = $"CALL update_hall({cinemaID}, {old_hallNumber}, {new_capacity});";
            return (bool)Command(sql).ExecuteScalar(); 
        }
    }
}
