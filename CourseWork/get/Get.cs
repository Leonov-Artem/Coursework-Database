using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class Get
    {
        MySqlConnection connection;

        public Get(MySqlConnection connection) => this.connection = connection;
        public MySqlCommand Command(string sql) => new MySqlCommand(sql, connection);

        static private string SplitAndJoin(string name)
        {
            string[] split = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            foreach (var s in split)
                result += s + " ";

            return result.Remove(result.Length - 1, 1);
        }
        private string СonvertFirstCharacterToUpperCase(string word)
            => word.Substring(0, 1).ToUpper() + word.Substring(1, word.Length - 1);
    }
}
