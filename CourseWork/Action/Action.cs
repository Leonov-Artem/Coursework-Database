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
        MySqlConnection connection;

        public Action(MySqlConnection connection) => this.connection = connection;
    }
}
