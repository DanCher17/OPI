using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

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
            string str = textBox1.Text;

            string piece = "";
            string piece2 = "";

            string result = "";
            int count = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    count++;
                }
                else if (str[i] != str[i + 1])
                {
                    if (count != 0)
                    {
                        piece = Convert.ToString(str[i]) + Convert.ToString(count + 1);
                    }
                    else piece = Convert.ToString(str[i]);

                    count = 0;
                    result += piece;
                }

                if (i == str.Length - 2)
                {
                    if (count != 0)
                    {
                        piece2 = Convert.ToString(str[i + 1]) + Convert.ToString(count + 1);
                        result += piece2;
                    }
                    else result += str[i + 1];
                }

            }
            textBox2.Text = result;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var regex = new Regex(@"(?<char>.)(?<count>\d+)");
            textBox2.Text = regex.Replace(textBox2.Text, m => new string(m.Groups["char"].Value[0], int.Parse(m.Groups["count"].Value)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(calc.Text);

            int[] a = new int[2];

            int j = 0;
            while (match.Success)
            {
                a[j] = Convert.ToInt32(match.Value);
                match = match.NextMatch();
                j++;
            }

            for (int i = 0; i < calc.Text.Length; i++)
            {
                switch (calc.Text[i])
                {
                    case '+':
                        result.Text = Convert.ToString(a[0] + a[1]);
                        break;
                    case '-':
                        result.Text = Convert.ToString(a[0] - a[1]);
                        break;
                    case '*':
                        result.Text = Convert.ToString(a[0] * a[1]);
                        break;
                    case '/':
                        result.Text = Convert.ToString(a[0] / a[1]);
                        break;
                }
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
