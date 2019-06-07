using MySql.Data.MySqlClient;

namespace CourseWork
{
    class Privilege
    {
        MySqlConnection connection;

        public Privilege(MySqlConnection connection) => this.connection = connection;

        private MySqlCommand Command(string sql) => new MySqlCommand(sql, connection);

        public bool AddUser(string login, string password, Position position)
        {
            string sql = $"SELECT add_new_user('{login}', '{password}', ";

            switch(position)
            {
                case Position.Administrator:
                    sql += "'админ');";
                    break;
                case Position.Cashier:
                    sql += "'кассир');";
                    break;
                case Position.Accountant:
                    sql += "'бухгалтер');";
                    break;
            }

            return (bool)Command(sql).ExecuteScalar();
        }
        public bool DeleteUser(string login, string password)
        {
            string sql = $"SELECT delete_user('{login}', '{password}');";
            return (bool)Command(sql).ExecuteScalar();
        }
        public bool UserExist(string login, string password)
        {
            string sql = $"SELECT check_user_existence('{login}', '{password}');";
            return (bool)Command(sql).ExecuteScalar();
        }
        public Position GetUserPosition(string login, string password)
        {
            string sql = $"SELECT get_user_position('{login}', '{password}');";
            string pos = Command(sql).ExecuteScalar().ToString();

            Position position = Position.NotSelected;
            switch(pos)
            {
                case "админ": return Position.Administrator;
                case "кассир": return Position.Cashier;
                case "бухгалтер": return Position.Accountant;
            }

            return position;
        }
    }
}
