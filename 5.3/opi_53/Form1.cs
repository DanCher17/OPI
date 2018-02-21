using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi_53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _timer.Start();
        }

        private int clicks = 0;

        private void textbox_MouseUp(object sender, MouseEventArgs e)
        {
            _timer.Stop();
            clicks++;
            
            if (clicks == 3)
            {
                Random rnd = new Random();
                
                Point pos = new Point(rnd.Next(8, 280), rnd.Next(8, 336));
                textbox.Location = pos;

                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                textbox.BackColor = randomColor;

                clicks = 0;
            }
                if (clicks < 3)
                {
                    _timer.Interval = 500;
                    _timer.Start();
                    _timer.Tick += (s, t) =>
                    {
                        _timer.Stop();
                        clicks = 0;
                    };
                }
            }
        }
    }
