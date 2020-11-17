using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int desiredNumber;
        int tries;
        int currentTry;
        Stack<int> stack;

        public Form2(int desiredNumber, int tries)
        {
            InitializeComponent();
            this.desiredNumber = desiredNumber;
            this.tries = tries;
            currentTry = tries;
            stack = new Stack<int>();
            buttonReset.Enabled = false;
            updateTries();
            MessageBox.Show($"Получите число {desiredNumber} за {tries} попыток!");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int number = int.Parse(labelNumber.Text) + 1;
            labelNumber.Text = number.ToString();
            stack.Push(number);
            currentTry--;
            updateTries();
            buttonReset.Enabled = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            int number = int.Parse(labelNumber.Text) * 2;
            labelNumber.Text = number.ToString();
            stack.Push(number);
            currentTry--;
            updateTries();
            buttonReset.Enabled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "0";
            currentTry = tries;
            stack = new Stack<int>();
            buttonReset.Enabled = false;
            updateTries();
        }
        private void updateTries()
        {
            labelTries.Text = currentTry.ToString();
            if (int.Parse(labelNumber.Text) == desiredNumber)
            {
                MessageBox.Show("Вы победили!");
                this.Hide();
            }
            if (currentTry == 0)
            {
                MessageBox.Show("Вы проиграли!");
                this.Hide();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            currentTry++;
            stack.Pop();
            if (stack.Count == 0)
            {
                return;
            }
            int previousNumber = stack.Pop();
            labelNumber.Text = previousNumber.ToString();
            stack.Push(previousNumber);
            updateTries();
        }
    }
}
