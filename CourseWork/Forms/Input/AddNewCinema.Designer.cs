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
            this.label3 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.backwards_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.category_textBox = new System.Windows.Forms.TextBox();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(279, 149);
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
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(199, 110);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(175, 22);
            this.address_textBox.TabIndex = 6;
            // 
            // category_textBox
            // 
            this.category_textBox.Location = new System.Drawing.Point(199, 71);
            this.category_textBox.Name = "category_textBox";
            this.category_textBox.Size = new System.Drawing.Size(175, 22);
            this.category_textBox.TabIndex = 7;
            this.category_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.category_textBox_KeyPress);
            // 
            // AddNewCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 287);
            this.Controls.Add(this.category_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.backwards_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button backwards_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox category_textBox;
    }
}