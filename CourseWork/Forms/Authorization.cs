using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class Authorization : Form
    {
        MySqlConnection connection;
        string Login { get; set; }
        string Password { get; set; }

        public Authorization(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Login = GetLoginFromTextBox();
            Password = GetPasswordFromTextBox();

            if (Login != "" || Password != "")
            {
                if (Privilege.UserExist(connection, Login, Password))
                    this.Hide();
                else
                {
                    MessageBox.Show("Пользователя с таким логином и паролем не сущесвтует!", "Ошибка!");
                    ClearFields();
                }
            }
            else
                MessageBox.Show("Введите логин и пароль!", "Ошибка!");
        }

        ///////////////////////////////////////////////////////////////////////////
        private void ClearFields()
        {
            login_textBox.Text = "";
            password_textBox.Text = "";
        }
        private string GetLoginFromTextBox() => login_textBox.Text;
        private string GetPasswordFromTextBox() => password_textBox.Text;
        public CurrentUser GetCurrentUser()
        {
            Position position = Privilege.GetUserPosition(connection, Login, Password);
            return new CurrentUser(Login, Password, position);
        }

        private void Exit_button_Click(object sender, EventArgs e) => Application.Exit();
    }
}
