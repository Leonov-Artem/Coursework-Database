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
        }

        private void Backwards_button_Click(object sender, EventArgs e) => Close();

        private void Change_button_Click(object sender, EventArgs e)
        {

        }
    }
}
