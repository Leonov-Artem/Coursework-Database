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

            AddItemsToListBox();
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
                {
                    MessageBox.Show("Пользователь добавлен!", "Уведомление");
                    AddItemsToListBox();
                }
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
        private void delete_button_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                string item = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(item);

                string[] loginPassword = item.Split(new string[] { " ", "(", ")" }, StringSplitOptions.RemoveEmptyEntries);
                Privilege.DeleteUser(connection, loginPassword[0], loginPassword[1]);
            }
            else
                MessageBox.Show("Выберите строку из списка!", "Ошибка!");
        }
        private void backwards_button_Click(object sender, EventArgs e) => Close();

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
            Position selectedPosition = Position.NotSelected;

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

        private string[] GetItemsFromUserTable()
        {
            string sql = "SELECT login, password FROM users";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();

            List<string> list = new List<string>();
            while (reader.Read())
                list.Add(reader[0] + " (" + reader[1] + ")");
            reader.Close();

            return list.ToArray();
        }
        private void AddItemsToListBox()
        {
            ClearListBox();
            string[] items = GetItemsFromUserTable();

            foreach(var item in items)
                listBox1.Items.Add(item);
        }
        private void ClearListBox()
        {
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();
        }
    }
}
