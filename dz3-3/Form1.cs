using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz3_3
{
    public partial class Form1 : Form
    {
        public StreamReader reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                this.reader = File.OpenText(open.FileName);
                this.textUpdate(this.reader.ReadToEnd());
                button2.Enabled = true;
                
            }
        }

        public void textUpdate(string text)
        {
            textBox1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this, textBox1.Text);
            f.Show();
        }
    }
}
