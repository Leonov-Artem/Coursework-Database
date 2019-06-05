namespace CourseWork
{
    partial class ChangeInformation
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
            this.information_groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.action_groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.backwards_button = new System.Windows.Forms.Button();
            this.forward_button = new System.Windows.Forms.Button();
            this.information_groupBox.SuspendLayout();
            this.action_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // information_groupBox
            // 
            this.information_groupBox.Controls.Add(this.radioButton4);
            this.information_groupBox.Controls.Add(this.radioButton3);
            this.information_groupBox.Controls.Add(this.radioButton2);
            this.information_groupBox.Controls.Add(this.radioButton1);
            this.information_groupBox.Location = new System.Drawing.Point(84, 49);
            this.information_groupBox.Name = "information_groupBox";
            this.information_groupBox.Size = new System.Drawing.Size(190, 151);
            this.information_groupBox.TabIndex = 0;
            this.information_groupBox.TabStop = false;
            this.information_groupBox.Text = "Информация";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(40, 111);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(64, 21);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Залы";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.InformationSwitch);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(40, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(79, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Сеансы";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.InformationSwitch);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Фильмы";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.InformationSwitch);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Кинотеатры";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.InformationSwitch);
            // 
            // action_groupBox
            // 
            this.action_groupBox.Controls.Add(this.radioButton7);
            this.action_groupBox.Controls.Add(this.radioButton6);
            this.action_groupBox.Controls.Add(this.radioButton5);
            this.action_groupBox.Location = new System.Drawing.Point(301, 49);
            this.action_groupBox.Name = "action_groupBox";
            this.action_groupBox.Size = new System.Drawing.Size(196, 151);
            this.action_groupBox.TabIndex = 1;
            this.action_groupBox.TabStop = false;
            this.action_groupBox.Text = "Действие";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(37, 84);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(138, 21);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Удалить данные";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.ActionSwitch);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(37, 57);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(147, 21);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Изменить данные";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.ActionSwitch);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(37, 30);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(129, 21);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Ввести данные";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.ActionSwitch);
            // 
            // backwards_button
            // 
            this.backwards_button.Location = new System.Drawing.Point(12, 323);
            this.backwards_button.Name = "backwards_button";
            this.backwards_button.Size = new System.Drawing.Size(87, 36);
            this.backwards_button.TabIndex = 2;
            this.backwards_button.Text = "Назад";
            this.backwards_button.UseVisualStyleBackColor = true;
            this.backwards_button.Click += new System.EventHandler(this.backwards_button_Click);
            // 
            // forward_button
            // 
            this.forward_button.Location = new System.Drawing.Point(133, 323);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(87, 36);
            this.forward_button.TabIndex = 3;
            this.forward_button.Text = "Далее";
            this.forward_button.UseVisualStyleBackColor = true;
            this.forward_button.Click += new System.EventHandler(this.forward_button_Click);
            // 
            // ChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 366);
            this.Controls.Add(this.forward_button);
            this.Controls.Add(this.backwards_button);
            this.Controls.Add(this.action_groupBox);
            this.Controls.Add(this.information_groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации";
            this.information_groupBox.ResumeLayout(false);
            this.information_groupBox.PerformLayout();
            this.action_groupBox.ResumeLayout(false);
            this.action_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox information_groupBox;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox action_groupBox;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button backwards_button;
        private System.Windows.Forms.Button forward_button;
    }
}