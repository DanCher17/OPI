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
namespace _7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2 = new Form2();
        string path;
        int counter = 0;
        string[] images;

        private void openFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                images = Directory.GetFiles(path, "*.jpg");
            }
            pictureBox1.Image = new Bitmap(images[counter]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter == 0) {
                counter = images.Length - 1;
            } else {
                counter--;
            }
            pictureBox1.Image = new Bitmap(images[counter]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter < images.Length - 1) {
                counter++;
            } else {
                counter = 0;
            }
            pictureBox1.Image = new Bitmap(images[counter]);
        }

        private void содержаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:/Users/DDD/Documents/2_KURS/OPI/7_3/help.chm");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

    }
}