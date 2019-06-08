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
    public partial class ChangeHallsInfo : Form
    {
        MySqlConnection connection;
        Action action;
        Get get;
        string cinema_id;
        string old_hall_humber;

        public ChangeHallsInfo(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            action = new Action(connection);
            get = new Get(connection);

            FillCinemaComboBox();
        }

        private void Change_button_Click(object sender, EventArgs e)
        {

        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        private void capacity_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void cinema_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cinema_desc = GetCinemaDescFromComboBox();
            cinema_id = get.CinemaId(cinema_desc);
            FillHallComboBox(cinema_id);
        }

        private void hall_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            old_hall_humber = GetHallNumberFormComboBox();
            string capacity = get.HallCapacity(cinema_id, old_hall_humber);
            SetFields(old_hall_humber, capacity);
        }

        ////////////////////////////////////////////////////////////////////////////
        private void FillCinemaComboBox()
        {
            ClearCinemaComboBox();
            string[] cinemas = get.CinemasWithAddresses();
            AddInfoToCinemaComboBox(cinemas);
        }
        private void FillHallComboBox(string cinema_id)
        {
            ClearHallComboBox();
            string[] halls = get.HallsNumbers(cinema_id);
            AddInfoToHallComboBox(halls);
        }

        private void AddInfoToCinemaComboBox(string[] info)
        {
            int max = info.Max(x => x.Length);
            cinema_comboBox.Width = 5 * max + 30;

            foreach (var cinema in info)
                cinema_comboBox.Items.Add(cinema);
        }
        private void AddInfoToHallComboBox(string[] info)
        {
            int max = info.Max(x => x.Length);
            hall_comboBox.Width = 5 * max + 30;

            foreach (var cinema in info)
                hall_comboBox.Items.Add(cinema);
        }

        private void ClearCinemaComboBox()
        {
            if (cinema_comboBox.Items.Count != 0)
                cinema_comboBox.Items.Clear();
        }
        private void ClearHallComboBox()
        {
            if (hall_comboBox.Items.Count != 0)
                hall_comboBox.Items.Clear();
        }

        private void SetFields(string old_hall_humber, string capacity)
        {
            hall_number_textBox.Text = old_hall_humber;
            capacity_textBox.Text = capacity;
        }

        private string GetCinemaDescFromComboBox() => cinema_comboBox.SelectedItem.ToString();
        private string GetHallNumberFormComboBox() => hall_comboBox.SelectedItem.ToString();
        private string GetNewHallNumberFromTextBox() => hall_number_textBox.Text;
        private string GetCapacityFromTextBox() => capacity_textBox.Text;
    }
}
