namespace CourseWork
{
    partial class AddNewHall
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
            this.cinemas_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacity_textBox = new System.Windows.Forms.TextBox();
            this.hall_number_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(13, 240);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 0;
            this.Backwards_button.Text = "Назад";
            this.Backwards_button.UseVisualStyleBackColor = true;
            this.Backwards_button.Click += new System.EventHandler(this.Backwards_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(118, 240);
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
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кинотеатр: ";
            // 
            // cinemas_comboBox
            // 
            this.cinemas_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinemas_comboBox.FormattingEnabled = true;
            this.cinemas_comboBox.Location = new System.Drawing.Point(106, 4);
            this.cinemas_comboBox.Name = "cinemas_comboBox";
            this.cinemas_comboBox.Size = new System.Drawing.Size(239, 24);
            this.cinemas_comboBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.capacity_textBox);
            this.panel1.Controls.Add(this.hall_number_textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cinemas_comboBox);
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 108);
            this.panel1.TabIndex = 4;
            // 
            // capacity_textBox
            // 
            this.capacity_textBox.Location = new System.Drawing.Point(106, 75);
            this.capacity_textBox.Name = "capacity_textBox";
            this.capacity_textBox.Size = new System.Drawing.Size(239, 22);
            this.capacity_textBox.TabIndex = 7;
            this.capacity_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacity_textBox_KeyPress);
            // 
            // hall_number_textBox
            // 
            this.hall_number_textBox.Location = new System.Drawing.Point(106, 43);
            this.hall_number_textBox.Name = "hall_number_textBox";
            this.hall_number_textBox.Size = new System.Drawing.Size(239, 22);
            this.hall_number_textBox.TabIndex = 6;
            this.hall_number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.capacity_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вместимсть:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер зала:";
            // 
            // AddNewHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Backwards_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить новый зал";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backwards_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cinemas_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox capacity_textBox;
        private System.Windows.Forms.TextBox hall_number_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}