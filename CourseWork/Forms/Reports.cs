﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void backwards_button_Click(object sender, EventArgs e) => Close();

        private void view_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кинотеатр: 'Победа'\nАдрес: ул. Мира 32", "Результат запроса");
        }
    }
}
