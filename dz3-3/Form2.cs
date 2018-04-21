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
    public partial class Form2 : Form
    {
        Form1 form;
        public Form2(Form1 form, string reader)
        {
            InitializeComponent();
            textBox1.Text = reader;
            this.form = form;
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            //создали экземпляр
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                //записываем в файл содержимое поля
                writer.Write(textBox1.Text); writer.Close();
                //закрываем writer
            }

            form.textUpdate(textBox1.Text);
            this.Close();
        }

    }
}
