using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExampleApp
{
    public partial class Form1 : Form
    {
        public delegate void ChangeTextDelegate(string newText);
        public Form1()
        {
            InitializeComponent();
        }
        private void ChangeTextToHello(string newText)
        {
            label1.Text = "Текст изменён на: " + newText;
        }
        // Метод для изменения текста на "Добро пожаловать!" 
        private void ChangeTextToWelcome(string newText)
        {
            label1.Text = "Добро пожаловать!";
        }
        // Метод для изменения текста на "Как дела?" 
        private void ChangeTextToHowAreYou(string newText)
        {
            label1.Text = "Как дела?";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeTextDel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeTextDelegate changeTextDel;
            Random random = new Random();
            int methodIndex = random.Next(1, 4);
            switch (methodIndex)
            {
                case 1:
                    changeTextDel = ChangeTextToHello;
                    break;
                case 2:
                    changeTextDel = ChangeTextToWelcome;
                    break;
                case 3:
                    changeTextDel = ChangeTextToHowAreYou;
                    break;
                default:
                    changeTextDel = ChangeTextToHello;
                    break;
            }
            changeTextDel("Текст изменён!");
        }
    }
}
