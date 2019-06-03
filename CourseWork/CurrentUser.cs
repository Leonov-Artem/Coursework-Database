using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class CurrentUser
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public Position Position { get; private set; }

        public CurrentUser(string login, string password, Position position)
        {
            Login = login;
            Password = password;
            Position = position;
        }
        public CurrentUser() { }
    }
}
