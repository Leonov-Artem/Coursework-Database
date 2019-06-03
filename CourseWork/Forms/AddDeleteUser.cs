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
        Position selectedPosition;

        public AddDeleteUser(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void AddNewUser_button_Click(object sender, EventArgs e)
        {
            string login = GetLoginFromTextBox();
            string password = GetPasswordFromTextBox();
            Position position = GetPositionFromTextBox();

            if (login != "" && password != "")
            {
                bool successfully = Privilege.AddUser(connection, login, password, position);

                if (successfully)
                    MessageBox.Show("Пользователь добавлен!", "Уведомление");
                else
                    MessageBox.Show("Пользователь с такой учетной записью уже существует!", "Ошибка!");
            }
            else
                MessageBox.Show("Введите логин, пароль и должность!", "Ошибка!");
        }
        private void position_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = position_comboBox.SelectedItem.ToString();
            
            switch(selectedState)
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
        }

        ///////////////////////////////////////////////////////////////////////////
        private void ClearFields()
        {
            login_textBox.Text = "";
            password_textBox.Text = "";
        }
        private string GetLoginFromTextBox() => login_textBox.Text;
        private string GetPasswordFromTextBox() => password_textBox.Text;
        private Position GetPositionFromTextBox()
        {
            string selectedState = position_comboBox.SelectedItem.ToString();

            switch (selectedState)
            {
                case "Администратор": return Position.Administrator;
                case "Кассир": return Position.Cashier;
                case "Бухгалтер": return Position.Accountant;
            }

            throw new Exception("Должность не выбрана!");
        }
    }
}
