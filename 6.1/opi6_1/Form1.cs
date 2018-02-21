using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace opi6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 5;
        }
        Random rand = new Random();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int num;
        int i = 0;
        int win = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != Convert.ToInt32(textBox2.Text))
            {
                num = rand.Next(0, chars.Length - 1);
                label1.Text = chars[num].ToString();
                label4.Text += label1.Text;
            }
            else
            {
                timer1.Stop();
                string text = "Сложность: " + trackBar1.Value.ToString() + " " + "Результат: " + win.ToString() + "/" + textBox2.Text + Environment.NewLine;
                File.AppendAllText("result.txt", text);

                string message = "Ваш результат: " + win.ToString() + "/" + textBox2.Text + "\nЖелаете продолжить?";
                DialogResult dr = MessageBox.Show(message, " ", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                            win = 0;
                            i = -1;
                            label1.Text = "*";
                            textBox1.Clear();
                            textBox2.Clear();
                            label4.Text = " ";
                            break;
                    case DialogResult.No: 
                        Application.Exit();
                        break;
                }
            }
            i++;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value) {
                case 1:
                    timer1.Interval = 1700;
                    break;
                case 2:
                    timer1.Interval = 1500;
                    break;
                case 3:
                    timer1.Interval = 1300;
                    break;
                case 4:
                    timer1.Interval = 1100;
                    break;
                case 5:
                    timer1.Interval = 900;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == label1.Text) {
                win++;
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string text = "Сложность: " +  trackBar1.Value.ToString() + " " + "Результат: " + win.ToString() + "/" + textBox2.Text + Environment.NewLine;
            File.AppendAllText("result.txt", text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(File.ReadAllText("result.txt"));
        }
    }
}
