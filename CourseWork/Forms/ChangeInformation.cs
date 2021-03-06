﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class ChangeInformation : Form
    {
        MySqlConnection connection;
        List<Control> list_controls = new List<Control>();
        List<Control> hall_controls = new List<Control>();
        Get get;
        Action action;

        public ChangeInformation(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            get = new Get(connection);
            action = new Action(connection);
        }

        private void backwards_button_Click(object sender, EventArgs e) => Close();

        private void forward_button_Click(object sender, EventArgs e)
        {
            RadioButton selected_information = SomeRadioButtonsChecked(information_groupBox.Controls);
            RadioButton selected_action = SomeRadioButtonsChecked(action_groupBox.Controls);

            if (selected_action != null && selected_information != null)
            {
                if (selected_information.Text == "Кинотеатры")
                {
                    if (selected_action.Text == "Ввести данные")
                        ShowAddNewCinemaForm();

                    else if (selected_action.Text == "Изменить данные")
                        ShowChangeCinemaDetailsForm();

                    else if (selected_action.Text == "Удалить данные")
                        DeleteCinema();
                }
                else if (selected_information.Text == "Фильмы")
                {
                    if (selected_action.Text == "Ввести данные")
                        ShowAddNewFilmForm();

                    else if (selected_action.Text == "Изменить данные")
                        ShowChangeFilmDetailsForm();

                    else if (selected_action.Text == "Удалить данные")
                        DeleteFilm();

                }
                else if (selected_information.Text == "Сеансы")
                {
                    if (selected_action.Text == "Ввести данные")
                    {
                        AddNewSession addNewSession = new AddNewSession();
                        addNewSession.ShowDialog();
                    }
                    else if (selected_action.Text == "Изменить данные")
                    {
                        ChangeSessionInfo changeSessionInfo = new ChangeSessionInfo();
                        changeSessionInfo.ShowDialog();
                    }
                    else if (selected_action.Text == "Удалить данные")
                    {
                        DeleteSession deleteSession = new DeleteSession();
                        deleteSession.ShowDialog();
                    }
                }
                else if (selected_information.Text == "Залы")
                {
                    if (selected_action.Text == "Ввести данные")
                        ShowAddNewHall();

                    else if (selected_action.Text == "Изменить данные")
                        ShowChangeHallsInfo();

                    else if (selected_action.Text == "Удалить данные")
                        ShowDeleteHall();

                }
                else
                    MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
            }
            else
                MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
        }

        private void InformationSwitch(object sender, EventArgs e)
        {
            
        }
        private void ActionSwitch(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            RadioButton selected_information = SomeRadioButtonsChecked(information_groupBox.Controls);

            DeleteAllNewControls();
            if (radioButton.Checked && selected_information != null && radioButton.Text == "Удалить данные")
            {
                if (selected_information.Text == "Кинотеатры")
                {
                    string[] cinemas = get.CinemasWithAddresses();
                    AddCinemasToComboBox(cinemas);
                }
                else if (selected_information.Text == "Фильмы")
                {
                    string[] info = get.InfoAboutFilms();
                     AddFilmsToComboBox(info);
                }
                else if (selected_information.Text == "Залы")
                {
                }
                else if (selected_information.Text == "Сеансы")
                {

                }
            }
        }

        ////////////////////ДЛЯ КИНОТЕАТРОВ//////////////////////////////////////////
        private void AddCinemasToComboBox(string[] cinemas)
        {
            Label label = CreateAndAddCinemaLabel();
            ComboBox comboBox = CreateAndAddCinemaComboBox(label);

            list_controls.Add(label);
            list_controls.Add(comboBox);

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

            list_controls.Add(label);

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
        private void AddFilmsToComboBox(string[] films)
        {
            Label label = CreateAndAddFilmLabel();
            ComboBox comboBox = CreateAndAddFilmComboBox(label);

            list_controls.Add(label);
            list_controls.Add(comboBox);

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

        ////////////////////ДЕЙСТВИЯ////////////////////////////////////////////////
        private void DeleteCinema()
        {
            ComboBox comboBox = SomeElementsComboBoxSelected(this.Controls);

            if (comboBox != null)
            {
                string cinema = comboBox.SelectedItem.ToString();
                Get.NameAndCinemaAddress(cinema, out string cinema_name, out string street_name, out string house_number);

                string address_id = get.AddressId(street_name, house_number);

                if (action.DeleteCinema(cinema_name, address_id))
                {
                    MessageBox.Show($"Кинотеатр '{cinema_name}' был успешно удален!", "Оповещение");
                    comboBox.Items.Remove(cinema);
                    action.DeleteAddress(address_id);
                }
                else
                    MessageBox.Show("Проверьте выбранные данные", "Ошибка!");
            }
            else
                MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
        }
        private void DeleteFilm()
        {
            ComboBox comboBox = SomeElementsComboBoxSelected(this.Controls);

            if (comboBox != null)
            {
                string film_descr = comboBox.SelectedItem.ToString();
                Get.FilmNameProdecerYear(film_descr, out string film_name, out string producer, out string year);

                if (action.DeleteFIlm(film_name, producer, year))
                {
                    MessageBox.Show($"Фильм '{film_name}' был успешно удален!", "Оповещение");
                    comboBox.Items.Remove(film_descr);
                }
                else
                    MessageBox.Show("Проверьте выбранные данные", "Ошибка!");
            }
            else
                MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
        }

        private void ShowDeleteHall()
        {
            DeleteHall deleteHall = new DeleteHall(connection);
            deleteHall.ShowDialog();
        }
        private void ShowAddNewHall()
        {
            AddNewHall addNewHall = new AddNewHall(connection);
            addNewHall.ShowDialog();
        }
        private void ShowChangeHallsInfo()
        {
            ChangeHallsInfo changeHallsInfo = new ChangeHallsInfo(connection);
            changeHallsInfo.ShowDialog();
        }
        private void ShowAddNewCinemaForm()
        {
            AddNewCinema addNewCinema = new AddNewCinema(connection);
            addNewCinema.ShowDialog();
        }
        private void ShowChangeFilmDetailsForm()
        {
            ChangeMovieInfo changeMovieInfo = new ChangeMovieInfo(connection);
            changeMovieInfo.ShowDialog();
        }
        private void ShowChangeCinemaDetailsForm()
        {
            ChangeCinemaDetails change = new ChangeCinemaDetails(connection);
            change.ShowDialog();
        }
        private void ShowAddNewFilmForm()
        {
            AddNewFilm addNewFilm = new AddNewFilm(connection);
            addNewFilm.ShowDialog();
        }

        ///////////////////////ДОПОЛНИТЕЛЬНЫЕ МЕТОДЫ////////////////////////////////
        private void DeleteAllNewControls()
        {
            if (list_controls.Count != 0)
            {
                foreach (var control in list_controls)
                    Controls.Remove(control);
            }

            list_controls.Clear();
        }
        private void DeleteHallsContols()
        {
            if (hall_controls.Count != 0)
            {
                foreach (var control in hall_controls)
                    Controls.Remove(control);
            }

            hall_controls.Clear();
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
        private ComboBox[] SomeElementsComboBox(Control.ControlCollection controls)
        {
            List<ComboBox> list = new List<ComboBox>();
            foreach (var control in controls)
            {
                ComboBox combo = control as ComboBox;

                if (combo != null && combo.SelectedItem != null)
                    list.Add(combo);
            }

            return list.ToArray();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyTicket buyTicket = new BuyTicket();
            buyTicket.ShowDialog();
        }
    }
}
