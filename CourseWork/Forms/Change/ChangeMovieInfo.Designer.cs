namespace CourseWork
{
    partial class ChangeMovieInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.films_comboBox = new System.Windows.Forms.ComboBox();
            this.Backwards_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.duration_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.year_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.genre_textBox = new System.Windows.Forms.TextBox();
            this.producer_textBox = new System.Windows.Forms.TextBox();
            this.country_textBox = new System.Windows.Forms.TextBox();
            this.film_name_textBox = new System.Windows.Forms.TextBox();
            this.actors_richTextBox = new System.Windows.Forms.RichTextBox();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фильмы:";
            // 
            // films_comboBox
            // 
            this.films_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.films_comboBox.FormattingEnabled = true;
            this.films_comboBox.Location = new System.Drawing.Point(150, 29);
            this.films_comboBox.Name = "films_comboBox";
            this.films_comboBox.Size = new System.Drawing.Size(167, 24);
            this.films_comboBox.TabIndex = 1;
            this.films_comboBox.SelectedIndexChanged += new System.EventHandler(this.films_comboBox_SelectedIndexChanged);
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(12, 554);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 2;
            this.Backwards_button.Text = "Назад";
            this.Backwards_button.UseVisualStyleBackColor = true;
            this.Backwards_button.Click += new System.EventHandler(this.Backwards_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(125, 554);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(95, 32);
            this.Change_button.TabIndex = 3;
            this.Change_button.Text = "Изменить";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // duration_maskedTextBox
            // 
            this.duration_maskedTextBox.Location = new System.Drawing.Point(135, 193);
            this.duration_maskedTextBox.Mask = "00:00:00";
            this.duration_maskedTextBox.Name = "duration_maskedTextBox";
            this.duration_maskedTextBox.Size = new System.Drawing.Size(276, 22);
            this.duration_maskedTextBox.TabIndex = 35;
            this.duration_maskedTextBox.ValidatingType = typeof(int);
            // 
            // year_maskedTextBox
            // 
            this.year_maskedTextBox.Location = new System.Drawing.Point(135, 128);
            this.year_maskedTextBox.Mask = "0000";
            this.year_maskedTextBox.Name = "year_maskedTextBox";
            this.year_maskedTextBox.Size = new System.Drawing.Size(276, 22);
            this.year_maskedTextBox.TabIndex = 34;
            this.year_maskedTextBox.ValidatingType = typeof(int);
            // 
            // genre_textBox
            // 
            this.genre_textBox.Location = new System.Drawing.Point(135, 160);
            this.genre_textBox.Name = "genre_textBox";
            this.genre_textBox.Size = new System.Drawing.Size(276, 22);
            this.genre_textBox.TabIndex = 33;
            // 
            // producer_textBox
            // 
            this.producer_textBox.Location = new System.Drawing.Point(135, 58);
            this.producer_textBox.Name = "producer_textBox";
            this.producer_textBox.Size = new System.Drawing.Size(276, 22);
            this.producer_textBox.TabIndex = 32;
            // 
            // country_textBox
            // 
            this.country_textBox.Location = new System.Drawing.Point(135, 92);
            this.country_textBox.Name = "country_textBox";
            this.country_textBox.Size = new System.Drawing.Size(276, 22);
            this.country_textBox.TabIndex = 31;
            // 
            // film_name_textBox
            // 
            this.film_name_textBox.Location = new System.Drawing.Point(135, 25);
            this.film_name_textBox.Name = "film_name_textBox";
            this.film_name_textBox.Size = new System.Drawing.Size(276, 22);
            this.film_name_textBox.TabIndex = 30;
            // 
            // actors_richTextBox
            // 
            this.actors_richTextBox.Location = new System.Drawing.Point(135, 358);
            this.actors_richTextBox.Name = "actors_richTextBox";
            this.actors_richTextBox.Size = new System.Drawing.Size(489, 124);
            this.actors_richTextBox.TabIndex = 29;
            this.actors_richTextBox.Text = "";
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(135, 228);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(489, 124);
            this.description_richTextBox.TabIndex = 28;
            this.description_richTextBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Длительность: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Актеры:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Описание: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Жанр: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Год выпуска: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Страна: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Продюсер:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Название: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.duration_maskedTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.year_maskedTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genre_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.producer_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.country_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.film_name_textBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.actors_richTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.description_richTextBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 489);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменения";
            // 
            // ChangeMovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Backwards_button);
            this.Controls.Add(this.films_comboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeMovieInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о фильме";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox films_comboBox;
        private System.Windows.Forms.Button Backwards_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.MaskedTextBox duration_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox year_maskedTextBox;
        private System.Windows.Forms.TextBox genre_textBox;
        private System.Windows.Forms.TextBox producer_textBox;
        private System.Windows.Forms.TextBox country_textBox;
        private System.Windows.Forms.TextBox film_name_textBox;
        private System.Windows.Forms.RichTextBox actors_richTextBox;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}