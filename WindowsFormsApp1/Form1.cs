using khamidova;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<IBook>books=new List<IBook>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Title = txtBookTitle.Text,
                Author = txtAuthor.Text,
                ISBN = txtISBN.Text
            };
            books.Add(book);
            UpdateBookList();
        }

        private void UpdateBookList()
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book.Title);
            }
        }


        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                books.RemoveAt(lstBooks.SelectedIndex);
                UpdateBookList();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            lstBooks.Items.Clear();
            foreach (var book in books)
            {
                lstBooks.Items.Add(book.Title);
            }
        }
    }
}
