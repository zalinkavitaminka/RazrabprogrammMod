using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zalina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 qwe;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            qwe = new Class1(textBox1, label2, label4, listBox1);
            // выполнение функций    
            qwe.Creating(textBox1, label2, label4, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void условиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Хамидова Залина");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
