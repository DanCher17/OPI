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
using System.Media;

namespace opi_62
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 
            dateTimePicker1.Value.Day, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), 0);
            string time = dateTimePicker1.Value.ToString();

            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            FileStream stream = File.Open(filename, FileMode.Create, FileAccess.Write);
            if (stream != null)
            {
                StreamWriter writer = new StreamWriter(stream);
                writer.Write("Будильник встановлено на: ");
                writer.Write("\r\n");
                writer.Write(time);
                writer.Write("\r\n");
                writer.Write("Повідомлення: " + textBox3.Text);
                writer.Flush();
                stream.Close();
            }
        }
    }
}
