namespace CourseWork
{
    partial class AddNewFilm
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
            this.Backwards_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.description_richTextBox = new System.Windows.Forms.RichTextBox();
            this.actors_richTextBox = new System.Windows.Forms.RichTextBox();
            this.film_name_textBox = new System.Windows.Forms.TextBox();
            this.country_textBox = new System.Windows.Forms.TextBox();
            this.producer_textBox = new System.Windows.Forms.TextBox();
            this.genre_textBox = new System.Windows.Forms.TextBox();
            this.year_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.duration_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(12, 496);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 0;
            this.Backwards_button.Text = "Назад";
            this.Backwards_button.UseVisualStyleBackColor = true;
            this.Backwards_button.Click += new System.EventHandler(this.Backwards_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(127, 496);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 32);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Продюсер:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страна: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Год выпуска: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Жанр: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Описание: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Актеры:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Длительность: ";
            // 
            // description_richTextBox
            // 
            this.description_richTextBox.Location = new System.Drawing.Point(127, 218);
            this.description_richTextBox.Name = "description_richTextBox";
            this.description_richTextBox.Size = new System.Drawing.Size(489, 124);
            this.description_richTextBox.TabIndex = 10;
            this.description_richTextBox.Text = "";
            // 
            // actors_richTextBox
            // 
            this.actors_richTextBox.Location = new System.Drawing.Point(127, 349);
            this.actors_richTextBox.Name = "actors_richTextBox";
            this.actors_richTextBox.Size = new System.Drawing.Size(489, 124);
            this.actors_richTextBox.TabIndex = 11;
            this.actors_richTextBox.Text = "";
            // 
            // film_name_textBox
            // 
            this.film_name_textBox.Location = new System.Drawing.Point(127, 18);
            this.film_name_textBox.Name = "film_name_textBox";
            this.film_name_textBox.Size = new System.Drawing.Size(276, 22);
            this.film_name_textBox.TabIndex = 12;
            // 
            // country_textBox
            // 
            this.country_textBox.Location = new System.Drawing.Point(127, 85);
            this.country_textBox.Name = "country_textBox";
            this.country_textBox.Size = new System.Drawing.Size(276, 22);
            this.country_textBox.TabIndex = 13;
            // 
            // producer_textBox
            // 
            this.producer_textBox.Location = new System.Drawing.Point(127, 51);
            this.producer_textBox.Name = "producer_textBox";
            this.producer_textBox.Size = new System.Drawing.Size(276, 22);
            this.producer_textBox.TabIndex = 14;
            // 
            // genre_textBox
            // 
            this.genre_textBox.Location = new System.Drawing.Point(127, 153);
            this.genre_textBox.Name = "genre_textBox";
            this.genre_textBox.Size = new System.Drawing.Size(276, 22);
            this.genre_textBox.TabIndex = 16;
            // 
            // year_maskedTextBox
            // 
            this.year_maskedTextBox.Location = new System.Drawing.Point(127, 121);
            this.year_maskedTextBox.Mask = "0000";
            this.year_maskedTextBox.Name = "year_maskedTextBox";
            this.year_maskedTextBox.Size = new System.Drawing.Size(276, 22);
            this.year_maskedTextBox.TabIndex = 18;
            this.year_maskedTextBox.ValidatingType = typeof(int);
            // 
            // duration_maskedTextBox
            // 
            this.duration_maskedTextBox.Location = new System.Drawing.Point(127, 186);
            this.duration_maskedTextBox.Mask = "00:00:00";
            this.duration_maskedTextBox.Name = "duration_maskedTextBox";
            this.duration_maskedTextBox.Size = new System.Drawing.Size(276, 22);
            this.duration_maskedTextBox.TabIndex = 19;
            this.duration_maskedTextBox.ValidatingType = typeof(int);
            // 
            // AddNewFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 540);
            this.Controls.Add(this.duration_maskedTextBox);
            this.Controls.Add(this.year_maskedTextBox);
            this.Controls.Add(this.genre_textBox);
            this.Controls.Add(this.producer_textBox);
            this.Controls.Add(this.country_textBox);
            this.Controls.Add(this.film_name_textBox);
            this.Controls.Add(this.actors_richTextBox);
            this.Controls.Add(this.description_richTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Backwards_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового фильма";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backwards_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox description_richTextBox;
        private System.Windows.Forms.RichTextBox actors_richTextBox;
        private System.Windows.Forms.TextBox film_name_textBox;
        private System.Windows.Forms.TextBox country_textBox;
        private System.Windows.Forms.TextBox producer_textBox;
        private System.Windows.Forms.TextBox genre_textBox;
        private System.Windows.Forms.MaskedTextBox year_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox duration_maskedTextBox;
    }
}