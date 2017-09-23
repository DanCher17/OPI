using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opi_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           switch (calc.Text[1]) {
                case '+':
                    result.Text = Convert.ToString(Convert.ToInt32("" + calc.Text[0]) + Convert.ToInt32("" + calc.Text[2]));
                    break;
                case '-':
                    result.Text = Convert.ToString(Convert.ToInt32("" + calc.Text[0]) - Convert.ToInt32("" + calc.Text[2]));
                    break;
                case '*':
                    result.Text = Convert.ToString(Convert.ToInt32("" + calc.Text[0]) * Convert.ToInt32("" + calc.Text[2]));
                    break;
                case '/':
                    result.Text = Convert.ToString(Convert.ToInt32("" + calc.Text[0]) / Convert.ToInt32("" + calc.Text[2]));
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pad_res.Text = textBox4.Text.PadLeft(Convert.ToInt32(textBox3.Text), Convert.ToChar(textBox5.Text));  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            char[] charsToTrim = textBox7.Text.ToCharArray();
            label16.Text = textBox6.Text.TrimEnd(charsToTrim);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str1 = textBox8.Text;
            StringBuilder sb = new StringBuilder().Append(textBox9.Text);
            string str2 = String.Intern(sb.ToString());

            if (object.ReferenceEquals(str1, str2))
                label17.Text = "Equal";
            else
                label17.Text = "Not equal";
        }
    }
}
