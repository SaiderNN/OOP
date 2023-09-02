namespace FinalGame
{
    public interface IBlock
    {
        void Hit(int[,] map);

    }

    public class Block : IBlock
    {
        internal int X;
        internal int Y;
        protected int HP;
        protected Image img;
        public virtual void Hit(int[,] map)
        {
            HP -= 1;
            if (HP == 0)
            {
                map[Y, X] = 0;
                map[Y, X + 1] = 0;
            }

        }


        public void Draw(Graphics g, Image img, int i, int j)
        {
            Rectangle rect = new Rectangle(j * 30, i * 30, 60, 30); // создание прямоугольника
            g.DrawImage(img, rect);
        }


    }

    public class NormalBlock : Block, IObserver
    {

        public void Update(int bx, int by, int[,] map)
        {
            if (Y == by && (X == bx || X + 1 == bx))
            {
                Hit(map);
            }
        }

        public NormalBlock(int x, int y, Image Im)
        {
            X = x;
            Y = y;
            img = Im;
            HP = 1;
        }

    }
    public class StrongBlock : Block, IObserver
    {
        public override void Hit(int[,] map)
        {
            HP -= 1;
            if(HP == 1)
            {
                map[Y, X] = 2;
                map[Y, X + 1] = 12;

            }
            if (HP == 0)
            {
                map[Y, X] = 0;
                map[Y, X + 1] = 0;
            }


        }

        public void Update(int bx, int by, int[,] map)
        {
            if (Y == by && (X == bx || X + 1 == bx))
            {
                Hit(map);
            }
        }

        public StrongBlock(int x, int y, Image Im)
        {
            X = x;
            Y = y;
            img = Im;
            HP = 2;

        }
    }

    public interface IBlockFactory
    {
        Block createBlock(String type, int x, int y, Image img);
    }


    public class BlockFactory : IBlockFactory
    {
            
         public Block createBlock(String type, int x, int y, Image im)
         {
                if ("normal".Equals(type))
                {
                return new NormalBlock(x, y, im);
                }
                else if ("strong".Equals(type))
                {
                    return new StrongBlock(x, y, im);
                }
                else throw new Exception("Type of block " + type + " is not supported");
         }
    }
}
            
