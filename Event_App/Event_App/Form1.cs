using One_hand_bandit;
using System.Diagnostics.Eventing.Reader;

namespace Event_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            band_game.Spinned += Spinn;
            band_game.summ = 1000;
            CountBox.Text = band_game.summ.ToString();

            imagesBox.Add(Pic1);
            imagesBox.Add(Pic2);
            imagesBox.Add(Pic3);
            pictureBox1.SendToBack();
            pictureBox1.TabStop = false;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;


        }

        private Bandit band_game = new Bandit();

        // —оздание списка изображений

        List<PictureBox> imagesBox = new List<PictureBox>();

        // «агрузка изображений и добавление их в список
        Image goldim = Image.FromFile("C:/Users/Saider/Downloads/gold1.png");

        Image berryim = Image.FromFile("C:/Users/Saider/Downloads/strawberry.png");

        Image xim = Image.FromFile("C:/Users/Saider/Downloads/x.png");



        private void Spinn(object sender, ResultEventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {

                switch (e.result[i])
                {

                    case "gold":
                        imagesBox[i].Image = goldim;
                        break;

                    case "berry":
                        imagesBox[i].Image = berryim;
                        break;

                    case "x":

                        imagesBox[i].Image = xim;
                        break;


                }
            }

            Thread.Sleep(200);
            if (band_game.summ <= 0) MessageBox.Show("Game Over");
            CountBox.Text = e.Summ.ToString();
        }

        private void button_pull_Click(object sender, EventArgs e)
        {
            Pic1.Image = null;
            Pic2.Image = null;
            Pic3.Image = null;
            band_game.Rolling();
            
        }

        private void Pic3_Click(object sender, EventArgs e)
        {

        }
    }
}