using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Stack
{
    public partial class Form1 : Form
    {

        private Stack<string> stack = new Stack<string>(); 

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            if (!string.IsNullOrEmpty(item))
            {
                stack.Push(item);
                textBox1.Clear();
                MessageBox.Show($"Элемент '{item}' добавлен в стек.");
            }
            else
            {
                MessageBox.Show("Введите элемент для добавления.");
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                string removedItem = stack.Pop();
                MessageBox.Show($"элемент '{removedItem}' удален из стека.");
            }
            else
            {
                MessageBox.Show("Стек пуст.");
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in stack)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
