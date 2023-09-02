using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinalGame
{
    public partial class Form1 : Form
    {
        private GameObject player;
        private GameObject ball;
        private Block Block;
        private bool isRightPressed;
        private bool isLeftPressed;
        private int[,] map;
        public int mapWidth = 30;
        public int mapHeight = 30;
        private Tuple<int, int> ballXY;
        private List<IObserver> _observers = new List<IObserver>();
        private BlockFactory factory = new BlockFactory();
        private int bricksumm = 0;



        Image playerImg = new Bitmap("C:/Users/Saider/Desktop/platform1.png");

        Image ballImg = new Bitmap("C:/Users/Saider/Downloads/ball4.png");

        Image brickImg = new Bitmap("C:/Users/Saider/Pictures/brick_green.png");

        Image strongbrickImg = new Bitmap("C:/Users/Saider/Pictures/brick_red.png");
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Init();
            bricksumm = 0;


        }

        public void Init()
        {
            this.Width = (mapWidth + 1) * 30 - 15;
            this.Height = (mapHeight + 5) * 30;
            map = new int[mapHeight, mapWidth];


            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    map[i, j] = 0;
                }
            }
            player = new GameObject(new PlayerFactory(), (mapWidth - 1) / 2, mapHeight - 1, playerImg);

            map[player.Y, player.X] = 9;
            map[player.Y, player.X + 1] = 99;
            map[player.Y, player.X + 2] = 999;
            Random rand = new Random();


            for (int i = 0; i < mapHeight / 3; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    // проверка, что x четный
                    if ((j % 2 == 0 && i > 3 && j > 3 && j < mapWidth - 4) && i % 2 == 0)
                    {


                        // создание рандомного типа блока
                        string blocktype = rand.Next(2) == 0 ? "strong" : "normal";
                        // создание блока
                        Block = factory.createBlock(blocktype, j, i, blocktype == "strong" ? strongbrickImg : brickImg);
                        // заполнение карты в зависимости от типа блока
                        if (blocktype == "strong")
                        {
                            map[Block.Y, Block.X] = 3;
                            map[Block.Y, Block.X + 1] = 13;
                        }
                        else
                        {
                            map[Block.Y, Block.X] = 2;
                            map[Block.Y, Block.X + 1] = 12;
                        }
                        // проверка условий для выложения смайлика
                        _observers.Add((IObserver)Block);
                    }
                }
            }


            ball = new GameObject(new BallFactory(_observers), player.X + 1, player.Y - 1, ballImg);
            map[ball.Y, ball.X] = 8;

        }

        protected override void OnPaint(PaintEventArgs e)
        {


            DrawMap(e.Graphics);
            e.Graphics.DrawRectangle(Pens.Blue, new Rectangle(0, 0, mapWidth * 30, (mapHeight) * 40));

        }
        public void DrawMap(Graphics g)
        {
            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 9)
                    {
                        player.DrawObj(g, i, j);

                    }

                    if (map[i, j] == 8)
                    {
                        ball.DrawObj(g, i, j);
                    }
                    if (map[i, j] == 3)
                    {
                        Block.Draw(g, strongbrickImg, i, j);
                    }
                    if (map[i, j] == 2)
                    {
                        Block.Draw(g, brickImg, i, j);
                    }
                }
            }

            for (int i = 0; i < mapHeight / 3; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (map[i, j] == 3 || map[i, j] == 2 || map[i, j] == 13 || map[i, j] == 2)
                    {
                        bricksumm += 1;
                    }

                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                isRightPressed = true;
            }

            if (e.KeyCode == Keys.A)
            {
                isLeftPressed = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                timer1.Start();
                timer1.Interval = 10;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                isRightPressed = false;
            }

            if (e.KeyCode == Keys.A)
            {
                isLeftPressed = false;

            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            map[player.Y, player.X] = 0;
            map[player.Y, player.X + 1] = 0;
            map[player.Y, player.X + 2] = 0;

            if (isRightPressed && player.X + 1 < mapWidth - 1 && player.X + 2 < mapWidth - 1)
            {
                player.X = player.MoveObjForward(map).Item1;

            }
            if (isLeftPressed && player.X > 0)
            {
                player.X = player.MoveObjForward(map).Item1 - 2;

            }
            map[player.Y, player.X] = 9;
            map[player.Y, player.X + 1] = 99;
            map[player.Y, player.X + 2] = 999;


            map[ball.Y, ball.X] = 0;

            ballXY = ball.MoveObjForward(map);
            ball.X = ballXY.Item1;
            ball.Y = ballXY.Item2;
            map[ball.Y, ball.X] = 8;

            Invalidate();

            if (ball.Y == mapHeight - 1 || bricksumm == 0)
            {
                timer1.Stop();
                MessageBox.Show("Game over!");
                isLeftPressed = false;
                isRightPressed = false;
                Init();
                Invalidate();

            }

        }


    }


}
