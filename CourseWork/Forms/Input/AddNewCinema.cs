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
    public partial class AddNewCinema : Form
    {
        MySqlConnection connection;

        public AddNewCinema(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }
        private void backwards_button_Click(object sender, EventArgs e) => Close();

        private void category_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
                e.Handled = true;
        }
    }
}
