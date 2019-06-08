namespace CourseWork
{
    partial class ChangeHallsInfo
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
            this.Change_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cinema_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.capacity_textBox = new System.Windows.Forms.TextBox();
            this.hall_number_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hall_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(12, 265);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 0;
            this.Backwards_button.Text = "Назад";
            this.Backwards_button.UseVisualStyleBackColor = true;
            this.Backwards_button.Click += new System.EventHandler(this.Backwards_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(123, 265);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(95, 32);
            this.Change_button.TabIndex = 1;
            this.Change_button.Text = "Изменить";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кинотеатр:";
            // 
            // cinema_comboBox
            // 
            this.cinema_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinema_comboBox.FormattingEnabled = true;
            this.cinema_comboBox.Location = new System.Drawing.Point(142, 22);
            this.cinema_comboBox.Name = "cinema_comboBox";
            this.cinema_comboBox.Size = new System.Drawing.Size(183, 24);
            this.cinema_comboBox.TabIndex = 3;
            this.cinema_comboBox.SelectedIndexChanged += new System.EventHandler(this.cinema_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.capacity_textBox);
            this.groupBox1.Controls.Add(this.hall_number_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 105);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменения";
            // 
            // capacity_textBox
            // 
            this.capacity_textBox.Location = new System.Drawing.Point(130, 69);
            this.capacity_textBox.Name = "capacity_textBox";
            this.capacity_textBox.Size = new System.Drawing.Size(183, 22);
            this.capacity_textBox.TabIndex = 3;
            this.capacity_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacity_textBox_KeyPress);
            // 
            // hall_number_textBox
            // 
            this.hall_number_textBox.Location = new System.Drawing.Point(130, 30);
            this.hall_number_textBox.Name = "hall_number_textBox";
            this.hall_number_textBox.Size = new System.Drawing.Size(183, 22);
            this.hall_number_textBox.TabIndex = 2;
            this.hall_number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacity_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Вместимость:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Номер зала:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Зал:";
            // 
            // hall_comboBox
            // 
            this.hall_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hall_comboBox.FormattingEnabled = true;
            this.hall_comboBox.Location = new System.Drawing.Point(142, 59);
            this.hall_comboBox.Name = "hall_comboBox";
            this.hall_comboBox.Size = new System.Drawing.Size(183, 24);
            this.hall_comboBox.TabIndex = 6;
            this.hall_comboBox.SelectedIndexChanged += new System.EventHandler(this.hall_comboBox_SelectedIndexChanged);
            // 
            // ChangeHallsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 306);
            this.Controls.Add(this.hall_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cinema_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Backwards_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangeHallsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о зале";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backwards_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cinema_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox capacity_textBox;
        private System.Windows.Forms.TextBox hall_number_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox hall_comboBox;
    }
}