namespace CourseWork
{
    partial class ChangeCinemaDetails
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
            this.cinema_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.catefory_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Backwards_button = new System.Windows.Forms.Button();
            this.Change_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.street_textBox = new System.Windows.Forms.TextBox();
            this.house_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кинотеатр:";
            // 
            // cinema_comboBox
            // 
            this.cinema_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinema_comboBox.FormattingEnabled = true;
            this.cinema_comboBox.Location = new System.Drawing.Point(104, 23);
            this.cinema_comboBox.Name = "cinema_comboBox";
            this.cinema_comboBox.Size = new System.Drawing.Size(197, 24);
            this.cinema_comboBox.TabIndex = 1;
            this.cinema_comboBox.SelectedIndexChanged += new System.EventHandler(this.cinema_comboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.house_textBox);
            this.groupBox1.Controls.Add(this.street_textBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.catefory_textBox);
            this.groupBox1.Controls.Add(this.name_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменения";
            // 
            // catefory_textBox
            // 
            this.catefory_textBox.Location = new System.Drawing.Point(113, 71);
            this.catefory_textBox.Name = "catefory_textBox";
            this.catefory_textBox.Size = new System.Drawing.Size(182, 22);
            this.catefory_textBox.TabIndex = 4;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(113, 35);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(182, 22);
            this.name_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Кол-во залов: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название: ";
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(12, 360);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 3;
            this.Backwards_button.Text = "Назад";
            this.Backwards_button.UseVisualStyleBackColor = true;
            this.Backwards_button.Click += new System.EventHandler(this.Backwards_button_Click);
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(125, 360);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(95, 32);
            this.Change_button.TabIndex = 4;
            this.Change_button.Text = "Изменить";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Улица: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Номер дома: ";
            // 
            // street_textBox
            // 
            this.street_textBox.Location = new System.Drawing.Point(113, 109);
            this.street_textBox.Name = "street_textBox";
            this.street_textBox.Size = new System.Drawing.Size(182, 22);
            this.street_textBox.TabIndex = 7;
            // 
            // house_textBox
            // 
            this.house_textBox.Location = new System.Drawing.Point(113, 143);
            this.house_textBox.Name = "house_textBox";
            this.house_textBox.Size = new System.Drawing.Size(182, 22);
            this.house_textBox.TabIndex = 8;
            // 
            // ChangeCinemaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 404);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Backwards_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cinema_comboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeCinemaDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о кинотеатре";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cinema_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Backwards_button;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.TextBox catefory_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox house_textBox;
        private System.Windows.Forms.TextBox street_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}