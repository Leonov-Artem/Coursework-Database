using MySql.Data.MySqlClient;

namespace CourseWork
{
    class Privilege
    {
        MySqlConnection connection;

        public Privilege(MySqlConnection connection) => this.connection = connection;

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

            MySqlCommand command = new MySqlCommand(sql, connection);     // объект для выполнения SQL-запроса
            return (bool)command.ExecuteScalar();
        }
        public bool DeleteUser(string login, string password)
        {
            string sql = $"SELECT delete_user('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            return (bool)command.ExecuteScalar();
        }
        public bool UserExist(string login, string password)
        {
            string sql = $"SELECT check_user_existence('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, connection); 
            return (bool)command.ExecuteScalar();
        }
        public Position GetUserPosition(string login, string password)
        {
            string sql = $"SELECT get_user_position('{login}', '{password}');";
            MySqlCommand command = new MySqlCommand(sql, connection);
            string pos = command.ExecuteScalar().ToString();

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
