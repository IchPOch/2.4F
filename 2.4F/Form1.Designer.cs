namespace _2._4F
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
            this.V = new System.Windows.Forms.TextBox();
            this.But = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // V
            // 
            this.V.Location = new System.Drawing.Point(12, 12);
            this.V.Multiline = true;
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(247, 193);
            this.V.TabIndex = 0;
            // 
            // But
            // 
            this.But.Location = new System.Drawing.Point(91, 211);
            this.But.Name = "But";
            this.But.Size = new System.Drawing.Size(75, 23);
            this.But.TabIndex = 1;
            this.But.Text = "Нажми";
            this.But.UseVisualStyleBackColor = true;
            this.But.Click += new System.EventHandler(this.But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.But);
            this.Controls.Add(this.V);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox V;
        private System.Windows.Forms.Button But;
    }
}

