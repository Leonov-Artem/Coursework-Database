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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectToMySQL.GetDBConnection();
            conn.Open();

            bool exist = Privilege.UserExist(conn, "херня", "1234");
          
            string sql = "SELECT street_name FROM addresses where id = 1 ";

            MySqlCommand command = new MySqlCommand(sql, conn);     // объект для выполнения SQL-запроса
            string name = command.ExecuteScalar().ToString();       // выполняем запрос и получаем ответ

            conn.Close();
        }
    }
}
