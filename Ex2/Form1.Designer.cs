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
            this.buttonGuess = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuess.Location = new System.Drawing.Point(57, 97);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(116, 40);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Угадать!";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumber.Location = new System.Drawing.Point(43, 37);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(140, 35);
            this.textBoxNumber.TabIndex = 1;
            // 
            // labelHint
            // 
            this.labelHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHint.Location = new System.Drawing.Point(28, 154);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(175, 36);
            this.labelHint.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество попыток:";
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTries.Location = new System.Drawing.Point(93, 237);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(30, 31);
            this.labelTries.TabIndex = 4;
            this.labelTries.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 288);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonGuess);
            this.Name = "Form1";
            this.Text = "Угадай число!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTries;
    }
}

