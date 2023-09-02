using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FinalGame
{
    public partial class Arcanoid : Form
    {
        public Arcanoid()
        {
            InitializeComponent();
        }

        private void Arcanoid_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Создать экземпляр второй формы
            Form1 form1 = new Form1();

            // Отобразить вторую форму
            form1.Show();
        }
    }
}
