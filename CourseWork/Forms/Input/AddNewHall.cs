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
    public partial class AddNewHall : Form
    {
        MySqlConnection connection;
        Action action;
        Get get;

        public AddNewHall(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            action = new Action(connection);
            get = new Get(connection);

            FillComboBox();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string hall_number = GetHallNumberFromTextBox();
            string capacity = GetCapacityFromTextBox();

            if (hall_number != "" && capacity != "" && CinemaSelected())
            {
                string cinema_desc = GetCinemaDescriptionFromComboBox();
                string cinema_id = get.CinemaId(cinema_desc);

                int max_halls = int.Parse(get.CinemaCategory(cinema_desc));
                int current_halls = int.Parse(get.CurrnetHallsNumber(cinema_id));

                if (current_halls + 1 <= max_halls)
                {
                    if (action.AddNewHall(cinema_id, hall_number, capacity))
                        MessageBox.Show($"Новый зал был успешно добавлен!", "Оповещение");
                    else
                        MessageBox.Show("Зал с таким номером уже существует!", "Ошибка!");
                }
                else
                    MessageBox.Show("Данный кинотеатр уже содержит информацию о всех залах!", "Ошибка!");

                ClearAddField();
            }
            else
                MessageBox.Show("Введите необходимые данные!", "Ошибка!");
        }
        private void capacity_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        ////////////////////////////////////////////////////////////////////////
        private void FillComboBox()
        {
            ClearComboBox();
            string[] cinemas = get.CinemasWithAddresses();
            AddCinemasToComboBox(cinemas);
        }
        private void AddCinemasToComboBox(string[] cinemas)
        {
            int max = cinemas.Max(x => x.Length);
            cinemas_comboBox.Width = 5 * max + 30;

            foreach (var cinema in cinemas)
                cinemas_comboBox.Items.Add(cinema);
        }
        private void ClearComboBox()
        {
            if (cinemas_comboBox.Items.Count != 0)
                cinemas_comboBox.Items.Clear();
        }
        private bool CinemaSelected() => cinemas_comboBox.Items != null;

        private void ClearAddField()
        {
            hall_number_textBox.Text = "";
            capacity_textBox.Text = "";
        }

        private string GetHallNumberFromTextBox() => hall_number_textBox.Text;
        private string GetCapacityFromTextBox() => capacity_textBox.Text;
        private string GetCinemaDescriptionFromComboBox() => cinemas_comboBox.SelectedItem.ToString();
    }
}
