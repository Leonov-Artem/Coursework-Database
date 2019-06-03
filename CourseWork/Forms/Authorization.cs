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

        public Authorization(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string login = GetLoginFromTextBox();
            string password = GetPasswordFromTextBox();

            if (login != "" || password != "")
            {
                if (Privilege.UserExist(connection, login, password))
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
    }
}
