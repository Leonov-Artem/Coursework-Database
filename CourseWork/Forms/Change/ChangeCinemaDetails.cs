using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CourseWork
{
    public partial class ChangeCinemaDetails : Form
    {
        MySqlConnection connection;
        Action action;
        Get get;
        string[] cinemas;
        string old_name;
        string old_category;
        string old_street;
        string old_house;

        public ChangeCinemaDetails(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            cinemas = GetCinemasWithAddresses();
            AddCinemasToComboBox(cinemas);

            action = new Action(connection);
            get = new Get(connection);
        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        private void Change_button_Click(object sender, EventArgs e)
        {
            string new_name = GetNameFromTextBox();
            string new_category = GetCategoryFromTextBox();
            string new_street = GetStreetFromTextBox();
            string new_house = GetHouseFromTextBox();

            if (new_name != "" && new_category != "" && new_street != "" && new_house != "")
            {
                string address_id = get.AddressId(old_street, old_house);
                string cinema_id = get.CinemaId(old_name, old_category, address_id);
                action.UpdateCinema(cinema_id, address_id, new_name, new_category, new_street, new_house);

                MessageBox.Show("Данные успешно изменены!", "Оповещение");
            }
            else
                MessageBox.Show("Проверьте данные!", "Ошибка!");
        }

        private void cinema_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        { 
            string selected = cinema_comboBox.SelectedItem.ToString();
            Get.NameAndCinemaAddress(selected, out string name, out string street, out string house);

            Get get = new Get(connection);
            string id = get.AddressId(street, house);
            string category = get.CinemaCategory(name, id);

            SetFields(name, category, street, house);
        }

        /////////////////////////////////////////////////////////////////////////////////
        private string[] GetCinemasWithAddresses()
        {
            Get get = new Get(connection);
            string[] cinemas = get.Cinemas();
            List<string> list = new List<string>();

            foreach (var cinema in cinemas)
                list.Add(cinema + " (" + get.Address(cinema.ToLower()) + ")");

            return list.ToArray();
        }
        private void AddCinemasToComboBox(string[] cinemas)
        {
            int max = cinemas.Max(x => x.Length);
            cinema_comboBox.Width = 5 * max + 30;

            foreach (var cinema in cinemas)
                cinema_comboBox.Items.Add(cinema);
        }

        private void SetFields(string name, string category, string street, string house)
        {
            name_textBox.Text = old_name = name;
            category_textBox.Text = old_category = category;
            street_textBox.Text = old_street = street;
            house_textBox.Text = old_house = house;
        }

        private string GetNameFromTextBox() => name_textBox.Text;
        private string GetCategoryFromTextBox() => category_textBox.Text;
        private string GetStreetFromTextBox() => street_textBox.Text;
        private string GetHouseFromTextBox() => house_textBox.Text;
    }
}
