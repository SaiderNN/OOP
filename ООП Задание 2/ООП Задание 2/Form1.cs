using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_Задание_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Variables used in code
        /// </summary>
        double vvod; double second; double first = 1; int iter = 0;
        /// <summary>
        /// Main Timer activated by clicking the button
        /// Counting an iteration
        /// Saving previous step value of variable second in variable first
        /// Saving next step of calculation in variable second
        /// Displaying the values
        /// Timer stops when step difference is less than 0.0001
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            iter++;
            first = second;
            second = ((vvod / first) + first) / 2;
            textBox3.Text = second.ToString();
            textBox4.Text = iter.ToString();
            textBox5.Text = Math.Abs(Math.Sqrt(vvod) - second).ToString("E");
            if(Math.Abs(Math.Sqrt(vvod) - second) < Math.Pow(10, -5))
            {
                timer1.Stop(); 
            }


        }
        /// <summary>
        /// Button click event
        /// Trying to parse the intered value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            iter = 0;
            if (!(Double.TryParse(textBox1.Text, out vvod)))
            {
                MessageBox.Show("Неверно задано число!!!");
                return;
            }
            if (vvod < 0)
            {
                MessageBox.Show("Введите положительно число!!!");
                return;
            }
            second = vvod / 2;
            textBox2.Text = Math.Sqrt(vvod).ToString();

            timer1.Start();
        }

    }
}
