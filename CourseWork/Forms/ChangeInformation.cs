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
    public partial class ChangeInformation : Form
    {
        MySqlConnection connection;
        List<Control> controls = new List<Control>();

        public ChangeInformation(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void backwards_button_Click(object sender, EventArgs e) => Close();

        private void forward_button_Click(object sender, EventArgs e)
        {
            RadioButton selected_information = SomeRadioButtonsChecked(information_groupBox.Controls);
            RadioButton selected_action = SomeRadioButtonsChecked(action_groupBox.Controls);
            
            Get get = new Get(connection);
            Action action = new Action(connection);

            if (selected_action != null && selected_information != null)
            {
                if (selected_information.Text == "Кинотеатры")
                { 
                    if (selected_action.Text == "Ввести данные")
                    {
                        AddNewCinema addNewCinema = new AddNewCinema(connection);
                        addNewCinema.ShowDialog();
                    }
                    else if (selected_action.Text == "Изменить данные")
                    {
                        
                    }
                    else if (selected_action.Text == "Удалить данные")
                    {
                        ComboBox comboBox = SomeElementsComboBoxSelected(this.Controls);

                        if (comboBox != null)
                        {
                            string cinema = comboBox.SelectedItem.ToString();
                            string[] split = cinema.Split(new char[] {' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                            string cinema_name = split[0];
                            string street_name = split[2];
                            string house_number = split[3];

                            string id = get.AddressId(street_name, house_number);

                            if (action.DeleteCinema(cinema_name, id))
                            {
                                MessageBox.Show($"Кинотеатр '{cinema_name}' был успешно удален!", "Оповещение");
                                comboBox.Items.Remove(cinema);
                            }
                            else
                                MessageBox.Show("Проверьте выбранные данные", "Ошибка!");
                        }
                        else
                            MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
                    }
                }
                else if (selected_information.Text == "Фильмы")
                {
                    if (selected_action.Text == "Ввести данные")
                    {

                    }
                    else if (selected_action.Text == "Изменить данные")
                    {

                    }
                    else if (selected_action.Text == "Удалить данные")
                    {
                        ComboBox comboBox = SomeElementsComboBoxSelected(this.Controls);

                        if (comboBox != null)
                        {
                            string cinema = comboBox.SelectedItem.ToString();
                            string[] split = cinema.Split(new char[] { ' ', '(', ')', ',' }, StringSplitOptions.RemoveEmptyEntries);

                            GetFilmNameProdecerYear(split, out string film_name, out string producer, out string year);

                            if (action.DeleteFIlm(film_name, producer, year))
                            {
                                MessageBox.Show($"Фильм '{film_name}' был успешно удален!", "Оповещение");
                                comboBox.Items.Remove(cinema);
                            }

                            else
                                MessageBox.Show("Проверьте выбранные данные", "Ошибка!");
                        }
                        else
                            MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
                    }
                }
                else if (selected_information.Text == "Сеансы")
                {
                    if (selected_action.Text == "Ввести данные")
                    {

                    }
                    else if (selected_action.Text == "Изменить данные")
                    {

                    }
                    else if (selected_action.Text == "Удалить данные")
                    {

                    }
                }
                else if (selected_information.Text == "Залы")
                {
                    if (selected_action.Text == "Ввести данные")
                    {

                    }
                    else if (selected_action.Text == "Изменить данные")
                    {

                    }
                    else if (selected_action.Text == "Удалить данные")
                    {

                    }
                }
                else
                    MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
            }
            else
                MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
        }

        private void InformationSwitch(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                DeleteAllNewControls();

                switch(radioButton.Text)
                {
                    case "Кинотеатры":
                        string[] cinemas = GetCinemasWithAddresses();
                        AddCinemasToComboBox(cinemas);
                        break;
                    case "Фильмы":
                        string[] info = GetInfoAboutFilms();
                        AddFilmsToComboBox(info);
                        break;
                    case "Сеансы":
                        break;
                    case "Залы":
                        break;
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////
        
        ////////////////////ДЛЯ КИНОТЕАТРОВ//////////////////////////////////////////
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
            Label label = CreateAndAddCinemaLabel();
            ComboBox comboBox = CreateAndAddCinemaComboBox(label);

            controls.Add(label);
            controls.Add(comboBox);

            int max = cinemas.Max(x => x.Length);
            comboBox.Width = 5 * max + 30;

            foreach (var cinema in cinemas)
                comboBox.Items.Add(cinema);
        }
        private Label CreateAndAddCinemaLabel()
        {
            Label label = new Label();
            label.Text = "Кинотеатры: ";
            label.Location = new Point(information_groupBox.Location.X, information_groupBox.Location.Y + information_groupBox.Size.Height + 10);
            Controls.Add(label);

            controls.Add(label);

            return label;
        }
        private ComboBox CreateAndAddCinemaComboBox(Label label)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(label.Location.X + label.Width, label.Location.Y);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Controls.Add(comboBox);

            return comboBox;
        }

        ////////////////////ДЛЯ ФИЛЬМОВ//////////////////////////////////////////////
        private string[] GetInfoAboutFilms()
        {
            Get get = new Get(connection);
            return get.InfoAboutFilms();
        }
        private void AddFilmsToComboBox(string[] films)
        {
            Label label = CreateAndAddFilmLabel();
            ComboBox comboBox = CreateAndAddFilmComboBox(label);

            controls.Add(label);
            controls.Add(comboBox);

            int max = films.Max(x => x.Length);
            comboBox.Width = 5 * max + 30;

            foreach (var film in films)
                comboBox.Items.Add(film);
        }
        private Label CreateAndAddFilmLabel()
        {
            Label label = new Label();
            label.Text = "Фильмы: ";
            label.Location = new Point(information_groupBox.Location.X, information_groupBox.Location.Y + information_groupBox.Size.Height + 10);
            Controls.Add(label);

            return label;
        }
        private ComboBox CreateAndAddFilmComboBox(Label label)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new Point(label.Location.X + label.Width, label.Location.Y);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Controls.Add(comboBox);

            return comboBox;
        }
        private void GetFilmNameProdecerYear(string[] split, out string film_name, out string producer, out string year)
        {
            year = split[split.Length - 1];
            producer = split[split.Length - 3] + " " + split[split.Length - 2];

            film_name = "";
            for (int i = 0; i < split.Length - 3; i++)
                film_name += split[i] + " ";

            film_name =  film_name.Remove(film_name.Length - 1, 1);
        }

        private void DeleteAllNewControls()
        {
            if (controls.Count != 0)
            {
                foreach (var control in controls)
                    Controls.Remove(control);
            }

            controls.Clear();
        }
        private RadioButton SomeRadioButtonsChecked(Control.ControlCollection controls)
        {
            foreach(var control in controls)
            {
                RadioButton radioButton = control as RadioButton;

                if (radioButton.Checked)
                    return radioButton;
            }
            return null;
        }
        private ComboBox SomeElementsComboBoxSelected(Control.ControlCollection controls)
        {
            foreach(var control in controls)
            {
                ComboBox combo = control as ComboBox;

                if (combo != null && combo.SelectedItem != null)
                    return combo;
            }
            return null;
        }
    }
}
