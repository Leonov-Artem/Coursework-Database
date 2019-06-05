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

        public ChangeInformation(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void backwards_button_Click(object sender, EventArgs e) => Close();

        private void forward_button_Click(object sender, EventArgs e)
        {
            var group1 = information_groupBox.Controls;
            var group2 = action_groupBox.Controls;

            if (SomeRadioButtonsChecked(group1) && SomeRadioButtonsChecked(group2))
            {

            }
            else
                MessageBox.Show("Выберите нужные параметры!", "Ошибка!");
        }

        private void InformationSwitch(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                switch(radioButton.Text)
                {
                    case "Кинотеатры":
                        string[] cinemas = GetCinemasWithAddresses();
                        AddCinemasToComboBox(cinemas);
                        break;
                    case "Фильмы":
                        break;
                    case "Сеансы":
                        break;
                    case "Залы":
                        break;
                }
            }
        }

        //////////////////////////////////////////////////////////
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

            foreach (var cinema in cinemas)
                comboBox.Items.Add(cinema);
        }
        private Label CreateAndAddCinemaLabel()
        {
            Label label = new Label();
            label.Text = "Кинотеатры: ";
            label.Location = new Point(information_groupBox.Location.X, information_groupBox.Location.Y + information_groupBox.Size.Height + 10);
            Controls.Add(label);

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

        private bool SomeRadioButtonsChecked(Control.ControlCollection controls)
        {
            foreach(var control in controls)
            {
                RadioButton radioButton = control as RadioButton;

                if (radioButton.Checked)
                    return true;
            }
            return false;
        }
        private bool SomeElementsComboBoxSelected(Control.ControlCollection controls)
        {
            foreach(var control in controls)
            {
                ComboBox combo = control as ComboBox;

                if (combo != null && combo.SelectedItem != null)
                    return true;
            }
            return false;
        }
    }
}
