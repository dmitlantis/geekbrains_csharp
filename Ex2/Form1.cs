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
        public Form1()
        {
            InitializeComponent();
        }

        private void numerik_ValueChanged(object sender, EventArgs e)
        {
            textBoxik.Text = (sender as NumericUpDown).Value.ToString();
        }
    }
}
