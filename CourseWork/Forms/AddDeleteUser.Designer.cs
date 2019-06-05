namespace CourseWork
{
    partial class AddDeleteUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewUser_button = new System.Windows.Forms.Button();
            this.position_comboBox = new System.Windows.Forms.ComboBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backwards_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewUser_button);
            this.groupBox1.Controls.Add(this.position_comboBox);
            this.groupBox1.Controls.Add(this.password_textBox);
            this.groupBox1.Controls.Add(this.login_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление пользователя";
            // 
            // AddNewUser_button
            // 
            this.AddNewUser_button.Location = new System.Drawing.Point(180, 158);
            this.AddNewUser_button.Name = "AddNewUser_button";
            this.AddNewUser_button.Size = new System.Drawing.Size(97, 37);
            this.AddNewUser_button.TabIndex = 6;
            this.AddNewUser_button.Text = "Добавить";
            this.AddNewUser_button.UseVisualStyleBackColor = true;
            this.AddNewUser_button.Click += new System.EventHandler(this.AddNewUser_button_Click);
            // 
            // position_comboBox
            // 
            this.position_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position_comboBox.FormattingEnabled = true;
            this.position_comboBox.Items.AddRange(new object[] {
            "Администратор",
            "Кассир",
            "Бухгалтер"});
            this.position_comboBox.Location = new System.Drawing.Point(118, 112);
            this.position_comboBox.Name = "position_comboBox";
            this.position_comboBox.Size = new System.Drawing.Size(159, 24);
            this.position_comboBox.TabIndex = 5;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(118, 72);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(159, 22);
            this.password_textBox.TabIndex = 4;
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(118, 38);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(159, 22);
            this.login_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_button);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(344, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление пользователя";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(136, 256);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(106, 32);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(16, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 204);
            this.listBox1.TabIndex = 0;
            // 
            // backwards_button
            // 
            this.backwards_button.Location = new System.Drawing.Point(12, 340);
            this.backwards_button.Name = "backwards_button";
            this.backwards_button.Size = new System.Drawing.Size(95, 32);
            this.backwards_button.TabIndex = 2;
            this.backwards_button.Text = "Назад";
            this.backwards_button.UseVisualStyleBackColor = true;
            this.backwards_button.Click += new System.EventHandler(this.backwards_button_Click);
            // 
            // AddDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.backwards_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/удаление пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox position_comboBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewUser_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button backwards_button;
    }
}