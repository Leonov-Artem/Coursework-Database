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
    public partial class AddNewCinema : Form
    {
        MySqlConnection connection;

        public AddNewCinema(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string cinema_name = GetNameFromTextBox();
            string category = GetCategoryFromTextBox();
            string street = GetStreetFromTextBox();
            string house = GetHouseFromTextBox();

            if (cinema_name != "" && category != "" && street != "" && house != "")
            {
                Action action = new Action(connection);

                if (action.AddNewCinema(cinema_name, category, street, house))
                    MessageBox.Show($"Кинотеатр '{cinema_name}' был успешно добавлен!", "Оповещение");
                else
                    MessageBox.Show("Введите необходимые данные!", "Ошибка!");
            }
            else
                MessageBox.Show("Введите необходимые данные!", "Ошибка!");
        }
        private void backwards_button_Click(object sender, EventArgs e) => Close();
        private void category_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        /////////////////////////////////////////////////////////////////////////////////
        private string GetNameFromTextBox()
        {
            string[] name = name_textBox.Text.Split(new string[] {" ", "-", "," }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            foreach (var n in name)
                result += n + " ";

            return result.Remove(result.Length - 1, 1);
        }
        private string GetCategoryFromTextBox() => category_textBox.Text;
        private string GetStreetFromTextBox() => street_textBox.Text;
        private string GetHouseFromTextBox() => house_textBox.Text;
    }
}
