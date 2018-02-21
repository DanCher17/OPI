using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 2;

            label2.Text = "Координаты кнопки: " + button1.Location.X.ToString() + "; " + button1.Location.Y.ToString();
        }

        private void goaway() {
            Random rnd = new Random();
            int WinW = this.Width;
            int WinH = this.Height;
            int ButW = button1.Width;
            int ButH = button1.Height;
            int _X, _Y;

            _X = rnd.Next(WinW - ButW);
            _Y = rnd.Next(WinH - ButH - 100);
            button1.SetBounds(_X, _Y, ButW, ButH);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = " Координаты курсора: " + e.X.ToString() + "; " + e.Y.ToString();

            int cx = e.X;
            int cy = e.Y;

            int x = button1.Location.X;
            int y = button1.Location.Y;

            switch (trackBar1.Value)
            {
                case 1:
                            if (cx - x > -8 && cx - x < 0) {
                                if (cy - y > 3 && cy - y < 22) {
                                    goaway();
                                }
                            }
                            if (cx - x > 75 && cx - x < 80) {
                                if (cy - y > 3 && cy - y < 22) {
                                    goaway();
                                }
                            }
                            if (cx - x > 3 && cx - x < 73) {
                                if (cy - y > 24 && cy - y < 26) {
                                    goaway();
                                }
                                if (cy - y > -6 && cy - y < -4) {
                                    goaway();
                                }
                            }
                            if (cx - x > -8 && cx - x < 0) {
                                if (cy - y > 3 && cy - y < 22) {
                                    goaway();
                                }
                            }
                            if (cx - x > 75 && cx - x < 80) {
                                if (cy - y > 3 && cy - y < 22) {
                                    goaway();
                                }
                            }
                            if (cx - x > 3 && cx - x < 73) {
                                if (cy - y > 24 && cy - y < 26) {
                                    goaway();
                                }
                                if (cy - y > -6 && cy - y < -4) {
                                    goaway();
                                }
                            }
                            break;
                   case 2:
                            if (cx - x > -8 && cx - x < 5) {
                                if (cy - y > 3 && cy - y < 27) {
                                    goaway();
                                }
                            }
                            if (cx - x > 75 && cx - x < 85) {
                                if (cy - y > 3 && cy - y < 27) {
                                    goaway();
                                }
                            }
                            if (cx - x > 3 && cx - x < 78) {
                                if (cy - y > 24 && cy - y < 31) {
                                    goaway();
                                }
                                if (cy - y > -6 && cy - y < 1) {
                                    goaway();
                                }
                            }
                            if (cx - x > -8 && cx - x < 5) {
                                if (cy - y > 3 && cy - y < 27) {
                                    goaway();
                                }
                            }
                            if (cx - x > 75 && cx - x < 85) {
                                if (cy - y > 3 && cy - y < 27) {
                                    goaway();
                                }
                            }
                            if (cx - x > 3 && cx - x < 78) {
                                if (cy - y > 24 && cy - y < 31) {
                                    goaway();
                                }
                                if (cy - y > -6 && cy - y < 1) {
                                    goaway();
                                }
                            }
                            break;
                }
            
            label2.Text = "Координаты кнопки: " + button1.Location.X.ToString() + "; " + button1.Location.Y.ToString();

        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            goaway();
            label2.Text = "Координаты кнопки: " + button1.Location.X.ToString() + "; " + button1.Location.Y.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Победа!");
        }

    }
}