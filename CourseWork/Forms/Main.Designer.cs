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
            this.InputChangeData_button = new System.Windows.Forms.Button();
            this.Reports_button = new System.Windows.Forms.Button();
            this.changeUser_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.addDelete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputChangeData_button
            // 
            this.InputChangeData_button.Location = new System.Drawing.Point(136, 156);
            this.InputChangeData_button.Name = "InputChangeData_button";
            this.InputChangeData_button.Size = new System.Drawing.Size(293, 35);
            this.InputChangeData_button.TabIndex = 1;
            this.InputChangeData_button.Text = "Ввод/удаление/измение данных";
            this.InputChangeData_button.UseVisualStyleBackColor = true;
            this.InputChangeData_button.Click += new System.EventHandler(this.InputChangeData_button_Click);
            // 
            // Reports_button
            // 
            this.Reports_button.Location = new System.Drawing.Point(136, 206);
            this.Reports_button.Name = "Reports_button";
            this.Reports_button.Size = new System.Drawing.Size(293, 34);
            this.Reports_button.TabIndex = 2;
            this.Reports_button.Text = "Отчеты";
            this.Reports_button.UseVisualStyleBackColor = true;
            this.Reports_button.Click += new System.EventHandler(this.Reports_button_Click);
            // 
            // changeUser_button
            // 
            this.changeUser_button.Location = new System.Drawing.Point(273, 394);
            this.changeUser_button.Name = "changeUser_button";
            this.changeUser_button.Size = new System.Drawing.Size(182, 44);
            this.changeUser_button.TabIndex = 3;
            this.changeUser_button.Text = "Зайти под другой учетной записью";
            this.changeUser_button.UseVisualStyleBackColor = true;
            this.changeUser_button.Click += new System.EventHandler(this.changeUser_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(473, 394);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(129, 44);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Выход";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // addDelete_button
            // 
            this.addDelete_button.Location = new System.Drawing.Point(136, 94);
            this.addDelete_button.Name = "addDelete_button";
            this.addDelete_button.Size = new System.Drawing.Size(293, 47);
            this.addDelete_button.TabIndex = 0;
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
            this.Controls.Add(this.Reports_button);
            this.Controls.Add(this.InputChangeData_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InputChangeData_button;
        private System.Windows.Forms.Button Reports_button;
        private System.Windows.Forms.Button changeUser_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button addDelete_button;
    }
}

