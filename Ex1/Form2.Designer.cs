using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form2
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(127, 12);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+1";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(127, 51);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiply.TabIndex = 1;
            this.buttonMultiply.Text = "x2";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(127, 90);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(127, 128);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(12, 22);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(30, 31);
            this.labelNumber.TabIndex = 4;
            this.labelNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Число попыток:";
            // 
            // labelTries
            // 
            this.labelTries.AutoSize = true;
            this.labelTries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTries.Location = new System.Drawing.Point(53, 124);
            this.labelTries.Name = "labelTries";
            this.labelTries.Size = new System.Drawing.Size(25, 25);
            this.labelTries.TabIndex = 6;
            this.labelTries.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 173);
            this.Controls.Add(this.labelTries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonPlus);
            this.Name = "Form2";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonPlus;
        private Button buttonMultiply;
        private Button buttonReset;
        private Button buttonCancel;
        private Label labelNumber;
        private Label label1;
        private Label labelTries;
    }
}