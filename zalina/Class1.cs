using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zalina
{
   class Class1
    {
        public string text;
        private int count = 0;
        private int temp = 0;
        private int count1 = 0;
        public Class1(TextBox t, Label l2, Label l4, ListBox lb)
        {

            text = t.Text;
        }
        public void Creating(TextBox t, Label l2, Label l4, ListBox lb)
        {
            // Определяем количество слов
            string[] str = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            count = str.Length;
            l2.Text = Convert.ToString(count);// вывод количества слов
            // определяем минимум и его индекс
            int min = str[0].Length;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length < min)
                {
                    min = str[i].Length;
                    temp = i;
                }
            }
            l4.Text = Convert.ToString(str[temp] + " :     под индексом " + temp);// вывод индекса
            lb.Items.Clear();
            // определяем сколько раз "А" встречается в каждом слове
            int[] name = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (str[i][j] == 'а' || str[i][j] == 'А')  
                    {
                        count1++;
                        name[i] = count1;
                    }
                }
            }
            string a = "";
            for (int i = 0; i < str.Length; i++)
            {
                a = Convert.ToString(str[i] + "  : буква 'A'  встречается " + name[i] + " раз\n");// вывод количества букв "a"
                lb.Items.Add(a);
            }
        }
    }
}

