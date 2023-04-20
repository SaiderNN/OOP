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

namespace ООП_2_Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.ReadOnly = true;
        }
        int f_num, s_num, nod;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(Int32.TryParse(textBox1.Text, out f_num)) || !(Int32.TryParse(textBox2.Text, out s_num)))
            {
                MessageBox.Show("Введите целое число!!");
                return;
            }

            textBox3.Text = NOD(f_num, s_num).ToString();

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