using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khamidova
{
    public class Book : IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Название:{Title}, Автор: {Author}, ISBN: {ISBN}");
        }
    }
}
