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
        string[] cinemas;

        public ChangeCinemaDetails(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            cinemas = GetCinemasWithAddresses();
            AddCinemasToComboBox(cinemas);
        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        private void Change_button_Click(object sender, EventArgs e)
        {

        }

        private void cinema_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get get = new Get(connection);

            string selected = cinema_comboBox.SelectedItem.ToString();
            GetNameAndAddress(selected, out string name, out string street, out string house);

            string id = get.AddressId(street, house);
            string category = get.CinemaCategory(name, id);

            name_textBox.Text = name;
            catefory_textBox.Text = category;
            street_textBox.Text = street;
            house_textBox.Text = house;
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
        private void GetNameAndAddress(string cinema, out string name, out string street, out string house)
        {
            var match = Regex.Match(cinema, @"^(.+)\s+\(");
            name = match.Groups[1].Value;
            name = SplitAndJoin(name);

            match = Regex.Match(cinema, @"\(.+\.\s+(.+)\,");
            street = match.Groups[1].Value;
            street = SplitAndJoin(street);

            match = Regex.Match(cinema, @",\s+(\w+.+\b)");
            house = match.Groups[1].Value;
        }


        private string SplitAndJoin(string name)
        {
            string[] split = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            foreach (var s in split)
                result += s + " ";

            return result.Remove(result.Length - 1, 1);
        }
    }
}
