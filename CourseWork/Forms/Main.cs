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
        private void Reports_button_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }
        private void InputChangeData_button_Click(object sender, EventArgs e)
        {
            ChangeInformation changeInformation = new ChangeInformation(connection);
            changeInformation.ShowDialog();
        }
        private void exit_button_Click(object sender, EventArgs e) => Application.Exit();
        private void changeUser_button_Click(object sender, EventArgs e) => RunAuthorization(connection);

        /////////////////////////////////////////////////////////////////////
        private void RunAuthorization(MySqlConnection connection)
        {
            Authorization authorization = new Authorization(connection);
            authorization.ShowDialog();

            currentUser = authorization.GetCurrentUser();
            SetStatusBar(currentUser);

            HideButtonsAccordingToPrivileges(currentUser);
        }
        private void SetStatusBar(CurrentUser currentUser)
        {
            switch (currentUser.Position)
            {
                case Position.Administrator:
                    this.Text = "(Администратор)";
                    break;
                case Position.Cashier:
                    this.Text = "(Кассир)";
                    break;
                case Position.Accountant:
                    this.Text = "(Бухгалтер)";
                    break;
            }
        }
        private void HideButtonsAccordingToPrivileges(CurrentUser currentUser)
        {
            addDelete_button.Enabled = true;
            InputChangeData_button.Enabled = true;

            switch (currentUser.Position)
            {
                case Position.Administrator:
                    addDelete_button.Enabled = true;
                    InputChangeData_button.Enabled = true;
                    break;
                case Position.Cashier:
                    addDelete_button.Enabled = false;
                    break;
                case Position.Accountant:
                    addDelete_button.Enabled = false;
                    InputChangeData_button.Enabled = false;
                    break;
            }
        }
    }
}
