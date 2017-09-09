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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            textBox5.Text = textBox6.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox3.Text);
            }
            catch (System.FormatException)
            {
                if (textBox3.Text == "-" || textBox3.Text == "")
                {
                    return;
                }
                textBox3.Clear();
                MessageBox.Show("Please enter only numbers.");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox4.Text);
                textBox7.Text = Convert.ToString(a - b);
            }
            catch (System.FormatException)
            {
                if (textBox4.Text == "-" || textBox4.Text == "")
                {
                    return;
                }
                textBox4.Clear();
                MessageBox.Show("Please enter only numbers.");
            }

        }

    }
}
    
