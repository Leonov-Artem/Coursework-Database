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
        }

        private void InformationSwitch(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            Get get = new Get(connection);
            if (radioButton.Checked)
            {
                switch(radioButton.Text)
                {
                    case "Кинотеатры":
                        string s = get.Address("победа");
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

        private void ActionSwitch(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////

    }
}
