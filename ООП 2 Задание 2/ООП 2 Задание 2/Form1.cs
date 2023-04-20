using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ООП_2_Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        public static int NOD(int num1, int num2, int num3)
        {
            int result = NOD(num1, num2); // находим НОД первых двух чисел

            result = NOD(result, num3); // находим НОД полученного результата и третьего числа

            return result;
        }

        public static int NOD(int num1, int num2, int num3, int num4)
        {
            int result = NOD(num1, num2, num3); // находим НОД первых трех чисел

            result = NOD(result, num4); // находим НОД полученного результата и четвертого числа

            return result;
        }
        public static int NOD(int num1, int num2, int num3, int num4, int num5)
        {
            int result = NOD(num1, num2, num3, num4); // находим НОД первых четырех чисел

            result = NOD(result, num5); // находим НОД полученного результата и пятого числа

            return result;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3 , num4 , num5 ;

            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2) && int.TryParse(textBox3.Text, out num3))
            {
                int result = NOD(num1, num2, num3);

                if (int.TryParse(textBox4.Text, out num4))
                {
                    result = NOD(result, num4);

                    if (int.TryParse(textBox5.Text, out num5))
                    {
                        result = NOD(result, num5);
                    }
                }

                textBox6.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите как минимум 3 целых числа");
            }
        }


    }
}
