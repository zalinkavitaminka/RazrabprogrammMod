using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnFilter.Click += btnFilter_Click;
            btnSort.Click += btnSort_Click;
        }

        private List<Book> books = new List<Book>
{
    new Book { Title = "1984", Author = "George Orwell", Year = 1949, Genre = "Dystopian" },
    new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Genre = "Fiction" },
    new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Genre = "Fiction" },
    new Book { Title = "Brave New World", Author = "Aldous Huxley", Year = 1932, Genre = "Dystopian" }
};



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = books;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.ToLower();
            var filteredBooks = books.Where(b => b.Title.ToLower().Contains(filter)).ToList();
            dataGridView1.DataSource = filteredBooks;

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var sortedBooks = books.OrderBy(b => b.Year).ToList();
            dataGridView1.DataSource = sortedBooks;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
