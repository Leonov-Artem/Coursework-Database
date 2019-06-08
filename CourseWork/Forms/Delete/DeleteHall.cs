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
    public partial class DeleteHall : Form
    {
        MySqlConnection connection;
        Action action;
        Get get;
        string cinema_id;

        public DeleteHall(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            action = new Action(connection);
            get = new Get(connection);

            FillCinemaComboBox();
        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        private void Delete_button_Click(object sender, EventArgs e)
        {
            var cinema = cinema_comboBox.SelectedItem;
            var hall = hall_comboBox.SelectedItem;

            if (cinema != null && hall != null)
            {
                string cinema_desc = cinema.ToString();
                string hall_humber = hall.ToString();

                string cinema_id = get.CinemaId(cinema_desc);
                string hall_id = get.HallId(cinema_id, hall_humber);

                action.DeleteHall(hall_id);
                hall_comboBox.Items.Remove(hall_humber);
                MessageBox.Show("Зал был успешно удален!", "Оповещение");
            }
            else
                MessageBox.Show("Выберите все данные!", "Ошибка!");
        }

        private void cinema_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cinema_desc = GetCinemaDescFromComboBox();
            cinema_id = get.CinemaId(cinema_desc);
            FillHallComboBox(cinema_id);
        }

        private void hall_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hall = GetHallNumberFormComboBox();
            string capacity = get.HallCapacity(cinema_id, hall);
        }

        /////////////////////////////////////////////////////////////////////////
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

        private string GetCinemaDescFromComboBox() => cinema_comboBox.SelectedItem.ToString();
        private string GetHallNumberFormComboBox() => hall_comboBox.SelectedItem.ToString();

        private bool CinemaSelected() => cinema_comboBox.Items != null;
        private bool HallSelected() => hall_comboBox.Items != null;
    }
}
