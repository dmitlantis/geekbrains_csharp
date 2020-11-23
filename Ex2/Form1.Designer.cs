namespace Ex2
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
            this.textBoxik = new System.Windows.Forms.TextBox();
            this.numerik = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numerik)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxik
            // 
            this.textBoxik.Location = new System.Drawing.Point(39, 35);
            this.textBoxik.Name = "textBoxik";
            this.textBoxik.Size = new System.Drawing.Size(159, 20);
            this.textBoxik.TabIndex = 0;
            this.textBoxik.Text = "0";
            // 
            // numerik
            // 
            this.numerik.Location = new System.Drawing.Point(39, 92);
            this.numerik.Name = "numerik";
            this.numerik.Size = new System.Drawing.Size(159, 20);
            this.numerik.TabIndex = 1;
            this.numerik.ValueChanged += new System.EventHandler(this.numerik_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 151);
            this.Controls.Add(this.numerik);
            this.Controls.Add(this.textBoxik);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxik;
        private System.Windows.Forms.NumericUpDown numerik;
    }
}

