using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalGame
{
    public abstract class GameObjectFactory
    {

        public abstract Movement CreateMovement();
        public abstract Draw CreateDraw();


    }

    public abstract class Draw
    {

        public abstract void Drawing(Graphics g, Image img, int i, int j);
    }

    public abstract class Movement
    {
        public abstract Tuple<int, int> MovingForward(int[,] map, int X, int Y);

    }

    class PlayerMovement : Movement
    {


        public override Tuple<int, int> MovingForward(int[,] map, int X, int Y)
        {
            X++;

            return new Tuple<int, int>(X, Y);
        }
        

    }

    class BallMovement : Movement, ISubject
    {

        public List<IObserver> _observers { get; set; }
        int dirX = 0;
        int dirY = -1;
        public override Tuple<int, int> MovingForward(int[,] map, int X, int Y)
        {

            if (!IsColliding(X, Y, dirX, dirY, map))
            {
                X += dirX;
            }
            if (!IsColliding(X, Y, dirX, dirY, map))
            {
                Y += dirY;
            }
            return new Tuple<int, int>(X, Y);

        }


        public bool IsColliding(int X, int Y, int dirX, int dirY, int[,] map)
        {
            if( X + dirX > map.GetLength(1) -1|| X + dirX < 0)
            {
                this.dirX *= -1;
                return true;
                
            }

            if (Y + dirY > map.GetLength(0) -1|| Y + dirY < 0)
            {
                this.dirY *= -1;
                return true;
            }


            if(map[Y + dirY, X ] == 9) 
            {
                this.dirX = -1; 
                this.dirY *= -1;
                return true;
            }
            if (map[Y + dirY, X + dirX] == 99 || map[Y + dirY, X] == 99)
            {
                this.dirX *= 1;
                this.dirY *= -1;
                return true;
            }
            if (map[Y + dirY, X + dirX] == 999 || map[Y + dirY, X] == 999)
            {
                this.dirX = 1;
                this.dirY = -1;
                return true;
            }

            if (map[Y + dirY, X] != 0)
            {
                Notify(X, Y + dirY, map);
                this.dirY *= -1;
                return true;

            }

            if (map[Y, X + dirX] != 0)
            {
                Notify(X + dirX, Y, map);
                this.dirX *= -1;
                return true;
            }

            if (map[Y + dirY, X + dirX] != 0)
            {
                Notify(X + dirX, Y + dirY, map);
                this.dirX *= -1;
                this.dirY *= -1;
                return true;
            }


            return false;

        }

        public void Notify(int bX, int bY, int[,] map)
        {
            
            foreach (var observer in _observers)
            {
              
                observer.Update(bX, bY, map);
            }
        }

        public BallMovement(List<IObserver> _Observers)
        {
            _observers = _Observers;
        }


    }

    class RectangleDraw : Draw
    {
        public override void Drawing(Graphics g, Image img, int i, int j)
        {

            Rectangle rect = new Rectangle(j * 30, i * 30, 90, 30); // создание прямоугольника
            g.DrawImage(img, rect);
        }
    }

    class CircleDraw : Draw
    {

        public override void Drawing(Graphics g, Image img, int i, int j)
        {

            Rectangle rect = new Rectangle(j * 30, i * 30, 30, 30); // создание прямоугольника
            g.DrawImage(img, rect);
        }
    }
    public class GameObject 
    {
        private GameObjectFactory Factory;
        private Movement movement;
        private Draw draw;
        public int X { get; set; }
        public int Y { get; set; }

        private Tuple<int, int> XY;

        private List<IObserver> _Observers;
        Image Img { get; set; }



        public GameObject(GameObjectFactory factory, int x, int y, Image image)
        {

            Factory = factory;
            movement = Factory.CreateMovement();
            draw = Factory.CreateDraw();
            X = x;
            Y = y;
            Img = image;
            

        }



        public Tuple<int, int> MoveObjForward(int[,] map)
        {
            XY = movement.MovingForward(map, X, Y);
            X = XY.Item1;
            Y = XY.Item2;

            return new Tuple<int, int>(X, Y);
        }

        public void DrawObj(Graphics g, int i, int j)
        {
            draw.Drawing(g, Img, i, j);
        }

    }

    public class PlayerFactory : GameObjectFactory
    {

        public override Movement CreateMovement()
        {
            return new PlayerMovement();
        }

        public override Draw CreateDraw()
        {
            return new RectangleDraw();
        }



    }


    public class BallFactory : GameObjectFactory

    {

        public List<IObserver> _observers;

        public override Movement CreateMovement()
        {
            return new BallMovement(_observers);
        }

        public override Draw CreateDraw()
        {
            return new CircleDraw();
        }

        public BallFactory(List<IObserver> _Observers) 
        {
            this._observers = _Observers;

        }

    }

    
}




