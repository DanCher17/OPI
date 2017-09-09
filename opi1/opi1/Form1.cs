using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi1
{
    public partial class Form1 : Form
    {
        double a, b;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                a = Convert.ToDouble(textBox3.Text);
                b = Convert.ToDouble(textBox4.Text);
                textBox7.Text = Convert.ToString(a - b);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Enter only digits!");
                textBox3.Text = String.Empty;
                textBox4.Text = String.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
