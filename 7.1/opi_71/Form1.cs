using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi_71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool drawPen;
        public Point PreviousPoint;
        public bool FirstClick;

        int choice = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            choice = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            choice = 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            choice = 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            choice = 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            choice = 5;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (choice)
            {
                case 1:
                    DrawLine(new Point(e.X, e.Y));
                    break;
                case 2:
                    drawPen = true;
                    break;
                case 3:
                    DrawRectangle (new Point (e.X, e.Y));
                    break;  
                case 4:
                    DrawEllipse (new Point (e.X, e.Y));
                    break;
                case 5:
                    DrawText(new Point(e.X, e.Y)) ;
                    break;

            }
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }
        Graphics g;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawPen)
            {
                Pen blackPen = new Pen(Color.Black, 3);
                Point point = new Point(e.X, e.Y);
                g = pictureBox1.CreateGraphics();
                g.DrawLine(blackPen, PreviousPoint, point);
                PreviousPoint = point;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawPen = false;
        }

        void DrawLine(Point point)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            Pen blackpen = new Pen(Color.Black, 3);
            g = pictureBox1.CreateGraphics();

            if (FirstClick == true) {
                g.DrawLine(blackpen, PreviousPoint, point);
                g.FillRectangle(b, point.X, point.Y, 3, 3);
                blackpen.Dispose();
                g.Dispose();
                FirstClick = false;
            } else {
                g.FillRectangle(b, point.X, point.Y, 3, 3);
                FirstClick = true;
            }
        }

        void DrawRectangle(Point point)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            Pen blackpen = new Pen(Color.Black, 3);
            g = pictureBox1.CreateGraphics();

            if (FirstClick == true) {
                g.DrawRectangle(blackpen, PreviousPoint.X, PreviousPoint.Y,
                point.X - PreviousPoint.X, point.Y - PreviousPoint.Y);
                g.FillRectangle(b, point.X, point.Y, 3, 3);
                blackpen.Dispose();
                g.Dispose();
                FirstClick = false;
            } else {
                g.FillRectangle(b, point.X, point.Y, 3, 3);
                FirstClick = true;
            }
        }

        void DrawEllipse(Point point)
        {
            SolidBrush b = new SolidBrush(Color.Red);
            Pen blackpen = new Pen(Color.Black, 3);
            g = pictureBox1.CreateGraphics();

            if (FirstClick == true) {
                g.DrawEllipse(blackpen, PreviousPoint.X, PreviousPoint.Y,
                point.X - PreviousPoint.X, point.Y - PreviousPoint.Y);
                blackpen.Dispose();
                g.Dispose();
                FirstClick = false;
            } else {
                FirstClick = true;
            }
        }

        void DrawText(Point point)
        {
            g = pictureBox1.CreateGraphics();

            Font titlefont = new Font("Consolas", 15);
            g.DrawString("C#", titlefont, new SolidBrush(Color.Blue),
            point.X, point.Y);
        }

        Bitmap bmpp;

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                Image image = Image.FromFile(openFileDialog1.FileName);
                int width = image.Width;
                int height = image.Height;
                pictureBox1.Width = width;
                pictureBox1.Height = height;
                bmpp = new Bitmap(Image.FromFile(openFileDialog1.FileName), width, height);
                pictureBox1.Image = bmpp;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "TIF File(*.tif)|*.tif|" +
                "PNG File(*.png)|*.png";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                    switch (strFilExtn)
                    {
                        case "bmp":
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case "jpg":
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case "gif":
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case "tif":
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                            break;
                        case "png":
                            pictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        default:
                            break;
                    }
                
            }
        }

        


        }

    }
