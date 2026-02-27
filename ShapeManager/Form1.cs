using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeManager
{
    public partial class Form1 : Form
    {
        private List<IShape> shapes = new List<IShape>();

        private TextBox txtParameter;
        private ComboBox cmbShapeType;
        private ListBox lstShapes;

        public Form1()
        {
            InitializeComponent();
            CreateControl();
        }

        private void CreateControl()
        {
            this.Text = "Управление фигурами";
            this.Size = new System.Drawing.Size(450, 350);

            // ComboBox для выбора типа
            cmbShapeType = new ComboBox();
            cmbShapeType.Items.AddRange(new object[] { "Круг", "Квадрат" });
            cmbShapeType.SelectedIndex = 0;
            cmbShapeType.Location = new System.Drawing.Point(20, 20);
            cmbShapeType.Size = new System.Drawing.Size(150, 25);
            this.Controls.Add(cmbShapeType);

            // TextBox для параметра
            txtParameter = new TextBox();
            txtParameter.Location = new System.Drawing.Point(180, 20);
            txtParameter.Size = new System.Drawing.Size(100, 25);
            this.Controls.Add(txtParameter);

            // Кнопка добавления
            Button btnAdd = new Button();
            btnAdd.Text = "Добавить";
            btnAdd.Location = new System.Drawing.Point(290, 20);
            btnAdd.Size = new System.Drawing.Size(100, 25);
            btnAdd.Click += btnAdd_Click;
            this.Controls.Add(btnAdd);

            // ListBox для фигур
            lstShapes = new ListBox();
            lstShapes.Location = new System.Drawing.Point(20, 60);
            lstShapes.Size = new System.Drawing.Size(400, 200);
            this.Controls.Add(lstShapes);

            // Кнопка удаления
            Button btnDelete = new Button();
            btnDelete.Text = "Удалить";
            btnDelete.Location = new System.Drawing.Point(20, 270);
            btnDelete.Size = new System.Drawing.Size(100, 30);
            btnDelete.Click += button2_Click;
            this.Controls.Add(btnDelete);
        }



        private void button2_Click(object sender, EventArgs e)
        {
           if (lstShapes.SelectedIndex != -1)
            {
                int index = lstShapes.SelectedIndex;
                shapes.RemoveAt(index);
                lstShapes.Items.RemoveAt(index);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtParameter.Text);
            IShape shape;
            if (cmbShapeType.SelectedIndex == 0)
                shape = new Circle(value);
            else
                shape = new Square(value);

            shapes.Add(shape);
            lstShapes.Items.Add(shape.GetShapeInfo());
            txtParameter.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
