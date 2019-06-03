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
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        CurrentUser currentUser;

        public Form1()
        {
            InitializeComponent();

            connection = ConnectToMySQL.GetDBConnection();
            connection.Open();

            RunAuthorization(connection);
        }

        private void addDelete_button_Click(object sender, EventArgs e)
        {
            AddDeleteUser addDeleteUser = new AddDeleteUser(connection);
            addDeleteUser.ShowDialog();
        }

        private void exit_button_Click(object sender, EventArgs e) => Application.Exit();

        private void changeUser_button_Click(object sender, EventArgs e) => RunAuthorization(connection);

        /////////////////////////////////////////////////////////////////////
        private void RunAuthorization(MySqlConnection connection)
        {
            Authorization authorization = new Authorization(connection);
            authorization.ShowDialog();

            currentUser = authorization.GetCurrentUser();

            if (currentUser.Position != Position.Administrator)
                addDelete_button.Visible = false;
        }
    }
}
