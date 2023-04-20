using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_задание_3
{
    public partial class Form1 : Form
    {
        int x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder value = new StringBuilder();
            if(!(Int32.TryParse(textBox1.Text.ToString(), out x)))
            {
                MessageBox.Show("Введено неправильное значение!!");
                return;
            }
            if (x < 0)
            {
                MessageBox.Show("Введите положительное значение!!");
                return;
            }
            if (x == 0) 
            {
                value.Insert(0, "0");
            }
            while (x > 0)
            {
                if ( x % 2 == 0)
                {
                    value.Insert(0, "0");
                }
                if (x % 2 != 0)
                {
                    value.Insert(0, "1");
                }
                x = x / 2;
            }
            label1.Text = value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
