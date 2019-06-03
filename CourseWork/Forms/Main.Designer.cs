namespace CourseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.reference_button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.changeUser_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.addDelete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reference_button
            // 
            this.reference_button.Location = new System.Drawing.Point(171, 156);
            this.reference_button.Name = "reference_button";
            this.reference_button.Size = new System.Drawing.Size(236, 35);
            this.reference_button.TabIndex = 0;
            this.reference_button.Text = "Ввод и иземение данных";
            this.reference_button.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Справка";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // changeUser_button
            // 
            this.changeUser_button.Location = new System.Drawing.Point(273, 394);
            this.changeUser_button.Name = "changeUser_button";
            this.changeUser_button.Size = new System.Drawing.Size(182, 44);
            this.changeUser_button.TabIndex = 2;
            this.changeUser_button.Text = "Зайди под другой учетной записью";
            this.changeUser_button.UseVisualStyleBackColor = true;
            this.changeUser_button.Click += new System.EventHandler(this.changeUser_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(473, 394);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(129, 44);
            this.exit_button.TabIndex = 3;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // addDelete_button
            // 
            this.addDelete_button.Location = new System.Drawing.Point(171, 103);
            this.addDelete_button.Name = "addDelete_button";
            this.addDelete_button.Size = new System.Drawing.Size(236, 47);
            this.addDelete_button.TabIndex = 4;
            this.addDelete_button.Text = "Добавление/удаление пользователей";
            this.addDelete_button.UseVisualStyleBackColor = true;
            this.addDelete_button.Click += new System.EventHandler(this.addDelete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.addDelete_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.changeUser_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reference_button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reference_button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button changeUser_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button addDelete_button;
    }
}

