using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateContextMenu();
        }

        private void CreateContextMenu()
        {
            this.ContextMenuStrip = menuStrip;
        }
        
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void додатковіФункціїToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (додатковіФункціїToolStripMenuItem1.Checked == true)
            {
                додатковіФункціїToolStripMenuItem1.Checked = false;
            }
            else додатковіФункціїToolStripMenuItem1.Checked = true;
            button29.Visible = !button29.Visible;
            button30.Visible = !button30.Visible;
            button31.Visible = !button31.Visible;
            button32.Visible = !button32.Visible;
            button33.Visible = !button33.Visible;
            button28.Visible = !button28.Visible;
        }
        private void тригонометричніФункціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (тригонометричніФункціїToolStripMenuItem.Checked == true)
            {
                тригонометричніФункціїToolStripMenuItem.Checked = false;
            }
            else тригонометричніФункціїToolStripMenuItem.Checked = true;
            button20.Visible = !button20.Visible;
            button21.Visible = !button21.Visible;
            button22.Visible = !button22.Visible;
            button23.Visible = !button23.Visible;
        }
        private void зворотніТригонометричніФункціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (зворотніТригонометричніФункціїToolStripMenuItem.Checked == true)
            {
                зворотніТригонометричніФункціїToolStripMenuItem.Checked = false;
            }
            else зворотніТригонометричніФункціїToolStripMenuItem.Checked = true;
            button24.Visible = !button24.Visible;
            button26.Visible = !button26.Visible;
            button25.Visible = !button25.Visible;
            button27.Visible = !button27.Visible;
        }

        double a, b;
        int count;
        bool znak = true;
        //digits buttons
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
        //znak and clear buttons
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;

            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "";
            label1.Text = "";
        }
        //operations buttons
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                label1.Text = a.ToString() + "+";
                znak = true;
            }
            catch (System.FormatException)
            {
                textBox1.ForeColor = Color.Red;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                label1.Text = a.ToString() + "-";
                znak = true;
            }
            catch (System.FormatException)
            {
                textBox1.ForeColor = Color.Red;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                label1.Text = a.ToString() + "*";
                znak = true;
            }
            catch (System.FormatException)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                label1.Text = a.ToString() + "/";
                znak = true;
            }
            catch (System.FormatException)
            {
                textBox1.ForeColor = Color.Red;
            }
        }
        //other operations
        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = "sin";
            count = 5;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = "cos";
            count = 6;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            label1.Text = "tg";
            count = 7;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "ctg";
            count = 8;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            label1.Text = "arcsin";
            count = 9;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            label1.Text = "arctg";
            count = 10;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            label1.Text = "arccos";
            count = 11;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            label1.Text = "arcctg";
            count = 12;
        }
        private void button28_Click(object sender, EventArgs e)
        {
            label1.Text = "sqrt";
            count = 13;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            label1.Text = "log";
            count = 14;
        }
        private void button30_Click(object sender, EventArgs e)
        {
            label1.Text = "ln";
            count = 15;
        }
        private void button31_Click(object sender, EventArgs e)
        {
            count = 16;
        }
        private void button32_Click(object sender, EventArgs e)
        {
            count = 17;
        }
        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 18;
                label1.Text = a.ToString() + "^";
                znak = true;
            }
            catch (System.FormatException)
            {
                textBox1.ForeColor = Color.Red;
            }
        }
        //calculate
        private void calc()
        {
            switch (count)
            {
                case 1:
                    try
                    {
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    catch (System.StackOverflowException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Занадто велике число!";
                        }
                    }
                    break;
                case 2:
                    try
                    {
                        b = a - double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    };
                    break;
                case 3:
                    try
                    {
                        b = a * double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 4:
                    try
                    {
                        double divider;
                        divider = double.Parse(textBox1.Text);
                        if (divider == 0.0)
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Ділення на 0 неможливе!";
                        }
                        else
                        {
                            b = a / divider;
                            textBox1.Text = b.ToString();
                        }
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;
                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }

                    break;

                case 5:
                    //sin
                    try
                    {
                        b = Math.Sin((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 6:
                    //cos
                    try
                    {
                        b = Math.Cos((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;
                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 7:
                    //tg
                    try
                    {
                        b = Math.Tan((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 8:
                    //ctg
                    try
                    {
                        b = 1f / Math.Tan((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 9:
                    //arcsin
                    try
                    {
                        b = Math.Asin((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 10:
                    //arctg
                    try
                    {
                        b = Math.Atan((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 11:
                    //arccos
                    try
                    {
                        b = Math.Acos((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 12:
                    //arcctg
                    try
                    {
                        b = Math.PI / 2 - Math.Atan((double.Parse(textBox1.Text) / 180D) * Math.PI);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 13:
                    try
                    {
                        b = Math.Sqrt(double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 14:
                    try
                    {
                        b = Math.Log(double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 15:
                    try
                    {
                        b = Math.Log10(double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 16:
                    try
                    {
                        b = double.Parse(textBox1.Text);
                        double fact = b;
                        for (double i = b - 1; i >= 1; i--)
                        {
                            try
                            {
                                fact = fact * i;
                            }
                            catch (System.StackOverflowException)
                            {
                                fact = 0;
                                textBox1.ForeColor = Color.Red;

                                if (textBox1.Text == "")
                                {
                                    textBox1.ForeColor = Color.Red;
                                    textBox1.Text = "Занадто велике число!";
                                }
                            }
                        }
                        b = fact;
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    
                    break;
                case 17:
                    try
                    {
                        b = Math.Pow(double.Parse(textBox1.Text), 2);
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                case 18:
                    try
                    {
                        b = Math.Pow(a, double.Parse(textBox1.Text));
                        textBox1.Text = b.ToString();
                    }
                    catch (System.FormatException)
                    {
                        textBox1.ForeColor = Color.Red;

                        if (textBox1.Text == "")
                        {
                            textBox1.ForeColor = Color.Red;
                            textBox1.Text = "Введіть число!";
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        // button =
        private void button19_Click(object sender, EventArgs e)
        {
            calc();
            label1.Text = "";
        }




       

        
       
        }
    }
