namespace CourseWork
{
    partial class AddNewCinema
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
            this.label2 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.backwards_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.category_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.street_textBox = new System.Windows.Forms.TextBox();
            this.house_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория (кол-во залов):";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(279, 180);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 32);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Добавить";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // backwards_button
            // 
            this.backwards_button.Location = new System.Drawing.Point(12, 243);
            this.backwards_button.Name = "backwards_button";
            this.backwards_button.Size = new System.Drawing.Size(95, 32);
            this.backwards_button.TabIndex = 4;
            this.backwards_button.Text = "Назад";
            this.backwards_button.UseVisualStyleBackColor = true;
            this.backwards_button.Click += new System.EventHandler(this.backwards_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(199, 29);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(175, 22);
            this.name_textBox.TabIndex = 5;
            // 
            // category_textBox
            // 
            this.category_textBox.Location = new System.Drawing.Point(199, 71);
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(175, 22);
            this.category_textBox.TabIndex = 7;
            this.category_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.category_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Улица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер дома: ";
            // 
            // street_textBox
            // 
            this.street_textBox.Location = new System.Drawing.Point(199, 108);
            this.street_textBox.Name = "street_textBox";
            this.street_textBox.Size = new System.Drawing.Size(175, 22);
            this.street_textBox.TabIndex = 10;
            // 
            // house_textBox
            // 
            this.house_textBox.Location = new System.Drawing.Point(199, 139);
            this.house_textBox.Name = "house_textBox";
            this.house_textBox.Size = new System.Drawing.Size(175, 22);
            this.house_textBox.TabIndex = 11;
            // 
            // AddNewCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 287);
            this.Controls.Add(this.house_textBox);
            this.Controls.Add(this.street_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.backwards_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddNewCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового кинотеатра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button backwards_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox category_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox street_textBox;
        private System.Windows.Forms.TextBox house_textBox;
    }
}