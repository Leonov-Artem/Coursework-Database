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
    public partial class AddDeleteUser : Form
    {
        MySqlConnection connection;

        public AddDeleteUser(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void AddNewUser_button_Click(object sender, EventArgs e)
        {
            string login = GetLoginFromTextBox();
            string password = GetPasswordFromTextBox();
            var item = position_comboBox.SelectedItem;

            if (login != "" && password != "" && item != null)
            {
                Position position = GetSelectedPosition(item.ToString());
                bool successfully = Privilege.AddUser(connection, login, password, position);

                if (successfully)
                    MessageBox.Show("Пользователь добавлен!", "Уведомление");
                else
                {
                    MessageBox.Show("Пользователь с таким паролем уже существует!", "Ошибка!");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Введите логин, пароль и должность!", "Ошибка!");
                ClearFields();
            }
        }

        ///////////////////////////////////////////////////////////////////////////
        private void ClearFields()
        {
            login_textBox.Text = "";
            password_textBox.Text = "";
        }
        private string GetLoginFromTextBox() => login_textBox.Text;
        private string GetPasswordFromTextBox() => password_textBox.Text;
        private Position GetSelectedPosition(string position)
        {
            Position selectedPosition = Position.Administrator;

            switch (position)
            {
                case "Администратор":
                    selectedPosition = Position.Administrator;
                    break;
                case "Кассир":
                    selectedPosition = Position.Cashier;
                    break;
                case "Бухгалтер":
                    selectedPosition = Position.Accountant;
                    break;
            }

            return selectedPosition;
        }
    }
}
