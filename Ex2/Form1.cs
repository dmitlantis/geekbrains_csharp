using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        int tries;
        int guessNumber;
        public Form1()
        {
            InitializeComponent();
            int min = 1;
            int max = 100;
            tries = (int)Math.Log(max - min + 1, 2) + 1;
            int count = 0;
            Random rnd = new Random();
            guessNumber = rnd.Next(min, max);
            MessageBox.Show($"Компьютер загадал число от {min} до {max}. Попробуйте угадать его за {tries} попыток");
            labelTries.Text = tries.ToString();
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBoxNumber.Text);
            if (number == guessNumber)
            {
                MessageBox.Show("Вы угадали!");
                return;
            } 
            if (number > guessNumber)
            {
                labelHint.Text = "Перелёт!";
            } else
            {
                labelHint.Text = "Недолёт!";
            }
            tries--;
            labelTries.Text = tries.ToString();
            if (tries == 0)
            {
                MessageBox.Show("Вы проиграли!");
            }
        }
    }
}
