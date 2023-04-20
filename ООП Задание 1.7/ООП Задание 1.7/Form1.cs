using System.Reflection.Metadata.Ecma335;

namespace ООП_Задание_1._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double x;
        private void In_Click(object sender, EventArgs e)
        {
            if (!(Double.TryParse(textBox1.Text, out x)))
            {
                MessageBox.Show("Некорректное число!!!");
                textBox1.Clear();
            }
            else
            {
                textBox2.Text = x.ToString();
            }
        }
    }
}