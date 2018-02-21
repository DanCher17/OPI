using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }

        public static double fact(int n)
        {
            return n == 1 ? 1 : n * fact(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);

            progressBar1.Value = 0;
            progressBar1.Maximum = N;

            double res = 0;

            for (int i = 1; i <= N; i++)
            {
                progressBar1.Value++;
                res += 1/(fact(i * i));
            }
           
            textBox2.Text = Convert.ToString(res);
        }
    }
}
