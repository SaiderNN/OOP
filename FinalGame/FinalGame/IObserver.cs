using System;

namespace FinalGame
{
    public interface IObserver
    {

        void Update(int bx, int by, int[,] map);
    }



    interface ISubject
    {
        void Notify(int X, int Y, int[,] map);

    }






}


