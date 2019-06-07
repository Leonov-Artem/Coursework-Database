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
    public partial class AddNewFilm : Form
    {
        MySqlConnection connection;
        Action action;

        public AddNewFilm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            action = new Action(connection);
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            string name         = GetNameFromTextBox();
            string producer     = GetProducerFromTextBox();
            string country      = GetCountryFromTextBox();
            string year         = GetYearFromTextBox();
            string genre        = GetGenreFromTextBox();
            string duration     = GetDurationFromTextBox();
            string description  = GetDescriptionFromTextBox();
            string actors       = GetActorsFromTextBox();

            if (name        != "" &&
                producer    != "" &&
                country     != "" &&
                year        != "" &&
                genre       != "" &&
                duration    != "" &&
                description != "" &&
                actors      != "")
            {
                action.AddNewFilm(name, producer, country, year, genre, duration, description, actors);
                MessageBox.Show($"Фильм '{name}' был успешно добавлен!", "Оповещение");
            }
            else
                MessageBox.Show("Введите данные!", "Ошибка!");
        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        ////////////////////////////////////////////////////////////////////////////////
        private string GetNameFromTextBox() => film_name_textBox.Text;
        private string GetProducerFromTextBox() => producer_textBox.Text;
        private string GetCountryFromTextBox() => country_textBox.Text;
        private string GetYearFromTextBox() => year_maskedTextBox.Text;
        private string GetDescriptionFromTextBox() => description_richTextBox.Text;
        private string GetActorsFromTextBox() => actors_richTextBox.Text;
        private string GetDurationFromTextBox() => duration_maskedTextBox.Text;
        private string GetGenreFromTextBox() => genre_textBox.Text;
    }
}
