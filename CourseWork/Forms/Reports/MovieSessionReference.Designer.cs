namespace CourseWork
{
    partial class MovieSessionReference
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
            this.Change_button = new System.Windows.Forms.Button();
            this.Backwards_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Change_button
            // 
            this.Change_button.Location = new System.Drawing.Point(123, 406);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(95, 32);
            this.Change_button.TabIndex = 3;
            this.Change_button.Text = "Сохранить";
            this.Change_button.UseVisualStyleBackColor = true;
            // 
            // Backwards_button
            // 
            this.Backwards_button.Location = new System.Drawing.Point(12, 406);
            this.Backwards_button.Name = "Backwards_button";
            this.Backwards_button.Size = new System.Drawing.Size(95, 32);
            this.Backwards_button.TabIndex = 2;
            this.Backwards_button.Text = "Сохранить";
            this.Backwards_button.UseVisualStyleBackColor = true;
            // 
            // MovieSessionReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Backwards_button);
            this.Name = "MovieSessionReference";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справка о сеансе фильма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Backwards_button;
    }
}