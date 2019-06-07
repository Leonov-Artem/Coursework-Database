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
        public void DeleteAddress(string id)
        {
            string sql = $"call delete_address({id});";
            Command(sql).ExecuteNonQuery();
        }
    }
}
