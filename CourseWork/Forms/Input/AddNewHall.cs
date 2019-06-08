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
        }

        private void Add_button_Click(object sender, EventArgs e)
        {

        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        ////////////////////////////////////////////////////////////////////////
    }
}
