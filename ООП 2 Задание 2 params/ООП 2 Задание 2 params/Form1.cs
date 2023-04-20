using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ООП_2_Задание_2_params
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string[] numbers = input.Split(' '); // разбиваем строку на массив строк, разделитель - пробел
            int[] intNumbers;
            try
            {
                intNumbers = Array.ConvertAll(numbers, int.Parse); // преобразуем массив строк в массив целых чисел
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверно введены значения");
                return;
            }
            int result = NOD(intNumbers);

            textBox2.Text = result.ToString();
        }

        public static int NOD(params int[] numbers)
        {
            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result = NOD(result, numbers[i]); // вызываем предыдущую перегрузку NOD
            }

            return result;
        }
        public static int NOD(int num1, int num2)
        {

            while (num2 != 0)
            {
                int save = num2;
                num2 = num1 % num2;
                num1 = save;
            }

            return Math.Abs(num1);
        }
    }
}
