using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int i = 0;
            int result = 1;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
            while (i < Convert.ToInt32(numericUpDown2.Value))
            {
                i++;
                result *= a;
                progressBar1.Value = result;
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;

            textBox1.Clear();
            progressBar1.Value = 0;
        }
    }
}
