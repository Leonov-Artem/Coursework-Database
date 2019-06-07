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

        }


        //////////////////////////////////////////////////////////////////////////////
        private void UpdateMovieInfo()
        {
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
    }
}
