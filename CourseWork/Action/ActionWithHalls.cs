﻿using System;
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
        public void UpdateHall(string cinemaID, string old_hallNumber, string new_capacity)
        {
            string sql = $"CALL update_hall({cinemaID}, {old_hallNumber}, {new_capacity});";
             Command(sql).ExecuteScalar(); 
        }
        public bool DeleteHall(string hall_id)
        {
            string sql = $"select delete_hall({hall_id});";
            return (bool)Command(sql).ExecuteScalar();
        }
    }
}
