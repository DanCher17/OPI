using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi_52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x = 0;
        private int y = 0;

        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
        }

        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                Point pos = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
                button.Location = PointToClient(pos);
                position2.Text = Convert.ToString(button.Location.X) + ";" + Convert.ToString(button.Location.Y);
            }

            if (button.Location.Y < 70)
            {
                part.Text = "Вверх";
                int i = button.Location.Y;
                while (i != 1)
                {
                    Point pos = new Point(button.Location.X, i);
                    button.Location = pos;
                    i--;
                }
            }
            if (button.Location.X < 90)
            {
                part.Text = "Лево";
                int i = button.Location.X;
                while (i != 1) {
                    Point pos = new Point(i, button.Location.Y);
                    button.Location = pos;
                    i--;
                }
            }
            if (button.Location.Y > 220)
            {
                part.Text = "Низ";
                int i = button.Location.Y;
                while (i != 309)
                {
                    Point pos = new Point(button.Location.X, i);
                    button.Location = pos;
                    i++;
                }
            }
            if (button.Location.X > 240)
            {
                part.Text = "Право";
                int i = button.Location.Y;
                while (i != 329)
                {
                    Point pos = new Point(i, button.Location.Y);
                    button.Location = pos;
                    i++;
                }
            }
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            position2.Text = Convert.ToString(button.Location.X) + ";" + Convert.ToString(button.Location.Y);
        }
    }
}
