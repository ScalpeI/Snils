namespace Snils
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
            this.saveSnils = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveSnils
            // 
            this.saveSnils.Location = new System.Drawing.Point(137, 29);
            this.saveSnils.Name = "saveSnils";
            this.saveSnils.Size = new System.Drawing.Size(75, 23);
            this.saveSnils.TabIndex = 8;
            this.saveSnils.Text = "Save";
            this.saveSnils.UseVisualStyleBackColor = true;
            this.saveSnils.Click += new System.EventHandler(this.saveSnils_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 129);
            this.Controls.Add(this.saveSnils);
            this.Name = "Form1";
            this.Text = "MAIL by ScalpeI";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button saveSnils;
    }
}

