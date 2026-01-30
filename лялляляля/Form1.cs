using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лялляляля
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public interface IShape
        {
            double Area();
            string GetShapeInfo();
        }

        public class Circle : IShape
        {
            public double Radius { get; set; }
            public Circle(double radius)
            {
                Radius = radius;
            }
            public double Area()
            {
                return Math.PI * Radius * Radius;
            }
            public string GetShapeInfo()
            {
                return $"Круг с радиусом {Radius}, площадь: {Area()}";
            }
        }

        public class Square : IShape
        {
            public double Side { get; set; }
            public Square(double side)
            {
                Side = side;
            }
            public double Area()
            {
                return Side * Side;
            }
            public string GetShapeInfo()
            {
                return $"Квадрат со стороной {Side}, площадь: {Area()}";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}