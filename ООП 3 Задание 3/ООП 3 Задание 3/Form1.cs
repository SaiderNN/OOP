using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_3_Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 2147483647;
        private void Checked_Method( int num )
        {
            try
            {
                checked
                {
                    num *= 2;
                }
            }
            catch   (OverflowException e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            textBox1.Text = num.ToString();
        }
        private void UnChecked_Method(int num)
        {
            try
            {
                unchecked
                {
                    num *= 2;
                }
            }
            catch (OverflowException e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            textBox2.Text = num.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Checked_Method(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UnChecked_Method(num);
        }
    }
}
