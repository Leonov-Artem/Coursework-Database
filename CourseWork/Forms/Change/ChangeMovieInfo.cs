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
    public partial class ChangeMovieInfo : Form
    {
        MySqlConnection connection;
        Get get;
        Action action;
        string old_name;
        string old_producer;
        string old_country;
        string old_year;
        string old_genre;
        string old_duration;
        string old_description;
        string old_actors;

        public ChangeMovieInfo(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            get = new Get(connection);
            action = new Action(connection);

            UpdateMovieInfo();
        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        private void Change_button_Click(object sender, EventArgs e)
        {
            string new_name         = GetNameFromTextBox();
            string new_producer     = GetProducerFromTextBox();
            string new_country      = GetCountryFromTextBox();
            string new_year         = GetYearFromTextBox();
            string new_genre        = GetGenreFromTextBox();
            string new_duration     = GetDurationFromTextBox();
            string new_description  = GetDescriptionFromTextBox();
            string new_actors       = GetActorsFromTextBox();

            if (new_name != "" &&
                new_producer != "" &&
                new_country != "" &&
                new_year != "" &&
                new_genre != "" &&
                new_duration != "" &&
                new_description != "" &&
                new_actors != "")
            {
                string film_id = get.FilmId(old_name, old_producer, old_year);
                action.UpdateFilm(film_id, new_name, new_producer, new_country, new_year, new_genre, new_duration, new_description, new_actors);

                MessageBox.Show("Запись была успешно изменена!", "Оповещение");
                ClearAllFields();
            }
            else
                MessageBox.Show("Введите данные!", "Ошибка!");
        }

        private void films_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = films_comboBox.SelectedItem.ToString();
            Get.FilmNameProdecerYear(selected, out string film_name, out string prod, out string year_of_issue);

            string film_id = get.FilmId(film_name, prod, year_of_issue);
            get.AllInfoAboutFilm(film_id, out string name,
                                                    out string producer,
                                                    out string country,
                                                    out string year,
                                                    out string genre,
                                                    out string duration,
                                                    out string description,
                                                    out string actors);

            SetFields(name, producer, country, year, genre, duration, description, actors);
        }

        //////////////////////////////////////////////////////////////////////////////
        private void UpdateMovieInfo()
        {
            ClearComboBox();
            string[] films = GetInfoAboutFilms();
            AddFilmsToComboBox(films);
        }
        private string[] GetInfoAboutFilms()
        {
            return get.InfoAboutFilms();
        }
        private void AddFilmsToComboBox(string[] films)
        {
            int max = films.Max(x => x.Length);
            films_comboBox.Width = 5 * max + 30;

            foreach (var film in films)
                films_comboBox.Items.Add(film);
        }
        private void ClearComboBox()
        {
            if (films_comboBox.Items.Count != 0)
                films_comboBox.Items.Clear();
        }

        private void SetFields(string name,
                               string producer   ,
                               string country    ,
                               string year       ,
                               string genre      ,
                               string duration   ,
                               string description,
                               string actors     )
        {
            film_name_textBox.Text          = old_name = name;
            producer_textBox.Text           = old_producer = producer;
            country_textBox.Text            = old_country = country;
            year_maskedTextBox.Text         = old_year = year;
            description_richTextBox.Text    = old_description = description;
            actors_richTextBox.Text         = old_actors = actors;
            duration_maskedTextBox.Text     = old_duration = duration;
            genre_textBox.Text              = old_genre = genre;
        }

        private void ClearAllFields()
        {
            film_name_textBox.Text = old_name               = "";
            producer_textBox.Text = old_producer            = "";
            country_textBox.Text = old_country              = "";
            year_maskedTextBox.Text = old_year              = "";
            description_richTextBox.Text = old_description  = "";
            actors_richTextBox.Text = old_actors            = "";
            duration_maskedTextBox.Text = old_duration      = "";
            genre_textBox.Text = old_genre = "";

            UpdateMovieInfo();
        }

        private string GetNameFromTextBox()         => film_name_textBox        .Text;
        private string GetProducerFromTextBox()     => producer_textBox         .Text;
        private string GetCountryFromTextBox()      => country_textBox          .Text;
        private string GetYearFromTextBox()         => year_maskedTextBox       .Text;
        private string GetDescriptionFromTextBox()  => description_richTextBox  .Text;
        private string GetActorsFromTextBox()       => actors_richTextBox       .Text;
        private string GetDurationFromTextBox()     => duration_maskedTextBox   .Text;
        private string GetGenreFromTextBox()        => genre_textBox            .Text;
    }
}
