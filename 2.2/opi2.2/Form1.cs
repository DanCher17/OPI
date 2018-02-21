using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opi2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx;
            ListView.SelectedIndexCollection collection = listView1.SelectedIndices;

            if (collection.Count == 0)
            {
                idx = listView1.Items.Count;
            }
            else idx = collection[0] + 1;
            
           listView1.Items.Insert(idx, textBox1.Text);
           textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idx;
            ListView.SelectedIndexCollection collection = listView2.SelectedIndices;

            if (collection.Count == 0)
            {
                idx = listView2.Items.Count;
            }
            else idx = collection[0] + 1;
          
            listView2.Items.Insert(idx, textBox2.Text);
            textBox2.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItemToMove in listView1.SelectedItems)
            {
                ListViewItem itemToAdd = (ListViewItem)listItemToMove.Clone();
                listView2.Items.Add(itemToAdd);
                listView1.Items.Remove(listItemToMove);
            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listItemToMove in listView2.SelectedItems)
            {
                ListViewItem itemToAdd = (ListViewItem)listItemToMove.Clone();
                listView1.Items.Add(itemToAdd);
                listView2.Items.Remove(listItemToMove);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView2.SelectedItems)
            {
                listView2.Items.Remove(eachItem);
            }
        }
    }
}
