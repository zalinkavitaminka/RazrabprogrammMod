using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    public partial class Form1 : Form
    {

        private Queue<string> queue = new Queue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (!string.IsNullOrEmpty(item))
            {
                queue.Enqueue(item);
                textBox1.Clear();
                MessageBox.Show("$'Элемент '{item}' добавлен в очередь.");
            }
            else
            {
                MessageBox.Show("Введите элемент для добавления.");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                string removedItem = queue.Dequeue();
                MessageBox.Show($"Элемент '{removedItem}' удален из очереди.");
            }
            else
            {
                MessageBox.Show("Очередь пуста.");
            }

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in queue)
            {
                listBox1.Items.Add(item);
            }

        }
    }
}
