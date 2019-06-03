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
    public partial class AddDeleteUser : Form
    {
        MySqlConnection connection;

        public AddDeleteUser(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void AddNewUser_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
