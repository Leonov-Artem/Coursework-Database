using System;
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
    public partial class MovieRentalReport : Form
    {
        public MovieRentalReport()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text files(*.docx)|*.docx|All files(*.*)|*.*";
        }

        private void Backwards_button_Click(object sender, EventArgs e)
        {

        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            //System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
