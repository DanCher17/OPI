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


namespace opi6_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> names = new List<string>();
        List<string> codes = new List<string>();

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyValue.ToString();
            names.Add(e.KeyCode.ToString());
            codes.Add(e.KeyValue.ToString());
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;

            FileStream stream = File.Open(filename, FileMode.Create, FileAccess.Write);

            if (stream != null)
            {
                StreamWriter writer = new StreamWriter(stream);
                string[] n = names.ToArray();
                string[] c = codes.ToArray();

                for (int i = 0; i < n.Length; i++)
                {
                    writer.Write(codes[i] + " - " + names[i]);
                    writer.Write("\r\n");
                }
                writer.Flush();
                stream.Close();
            }
        }
    }
}
