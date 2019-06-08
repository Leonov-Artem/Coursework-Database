namespace CourseWork
{
    partial class DeleteHall
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
            this.hall_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cinema_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Backwards_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hall_comboBox
            // 
            this.hall_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hall_comboBox.FormattingEnabled = true;
            this.hall_comboBox.Location = new System.Drawing.Point(130, 54);
            this.hall_comboBox.Name = "hall_comboBox";
            this.hall_comboBox.Size = new System.Drawing.Size(183, 24);
            this.hall_comboBox.TabIndex = 10;
            this.hall_comboBox.SelectedIndexChanged += new System.EventHandler(this.hall_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Зал:";
            // 
            // cinema_comboBox
            // 
            this.cinema_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinema_comboBox.FormattingEnabled = true;
            this.cinema_comboBox.Location = new System.Drawing.Point(130, 17);
            this.cinema_comboBox.Name = "cinema_comboBox";
            this.cinema_comboBox.Size = new System.Drawing.Size(183, 24);
            this.cinema_comboBox.TabIndex = 8;
            this.cinema_comboBox.SelectedIndexChanged += new System.EventHandler(this.cinema_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Кинотеатр:";
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(12, 140);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 11;
            this.Backwards_button.Text = "Назад";
            this.Backwards_button.UseVisualStyleBackColor = true;
            this.Backwards_button.Click += new System.EventHandler(this.Backwards_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(130, 140);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(95, 32);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // DeleteHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 186);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Backwards_button);
            this.Controls.Add(this.hall_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cinema_comboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox hall_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cinema_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backwards_button;
        private System.Windows.Forms.Button Delete_button;
    }
}