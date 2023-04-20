///<summary>
///Задание 1.1
///</summary>
namespace project
{
    public static class Implicit
    {
        /*          Таблица неявных преобразований

        byte    :    short, ushort, int, uint, long, ulong, float, double, decimal
        sbyte   :    short, int, long, float, double, decimal
        short   :    int, long, float, double, decimal
        ushort  :    int, uint, long, ulong, float, double, decimal
        int     :    long, float, double, decimal
        uint    :    long, ulong, float, double, decimal
        long    :    float, double, decimal
        ulong   :    float, double, decimal
        float   :    double
        char    :    ushort, int, uint, long, ulong, float, double, decimal    

        */

        public static void Exes1(byte x)
        {
            int e = x;
            Console.WriteLine($"{x} - it's {x.GetType()}");
            Console.WriteLine($"{e} - it's {e.GetType()}\n");
        }
    }

   public static class Explicit
   {
        /*          Таблица явных преобразований
        sbyte | short, int, long, float, double, decimal 
        byte | short, ushort, int, uint, long, ulong, float, double, decimal 
        short | sbyte, byte, char, ushort, int, uint, long, ulong, float, double, decimal 
        ushort | sbyte, byte, char, short, int, uint, long, ulong, float, double, decimal 
        int | sbyte, byte, char, short, ushort, uint, long, ulong, float, double, decimal 
        uint | byte, char, ushort, int, long, ulong, float, double, decimal 
        long | sbyte, byte, char, short, ushort, int, uint, ulong, float, double, decimal 
        ulong | byte, char, ushort, uint, long, float, double, decimal 
        char | sbyte, byte, short, ushort, int, uint, long, ulong, float, double, decimal 
        float | sbyte, byte, short, ushort, int, uint, long, ulong, char, decimal 
        double | sbyte, byte, short, ushort, int, uint, long, ulong, char, float, decimal 
        decimal | sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double 
             */
        public static void Exes2(byte b)
       {
           char h = (char)b;
           Console.WriteLine($"{b} - it's {b.GetType()}");
           Console.WriteLine($"{h} - it's {h.GetType()}\n");
       }
   }

   public static class Exception
   {
       public static void Exes3( int r )
       {
           try
           { short b = Convert.ToInt16(r); }
           catch(System.OverflowException)
           {
              Console.WriteLine($"Упс, преобразование {r} в тип short невозможно\n");
           }
       }

   }
   public static class As_n_is
   {
       class Human
       {
           private string name = "Alex";
           public string Name
           {
               get { return name; }
               set { name = value; }
           }
       }
       class Worker : Human
       {
           int age = 30;
       }
       public static void Exes4()
       {
           Worker obj1 = new Worker();
           Human obj2 = new Human();
            obj2.Name = "Me";
           if (obj1 is Human man1)
           {
               Console.WriteLine(man1.Name);
           }
           else { Console.WriteLine("1 (is)Ошибка, объект нельзя преобразовать"); }
           if (obj2 is Worker man2)
           {
               Console.WriteLine(man2.Name);
           }
           else { Console.WriteLine("2 (is)Ошибка, объект нельзя преобразовать\n"); }

           Human me = obj1 as Human;
            if (me == null)
           {
               Console.WriteLine("1 (as)Ошибка, объект нельзя преобразовать");
           }
           else { Console.WriteLine(me.Name); }
           Worker you = obj2 as Worker; 
           if (you == null) 
           { 
               Console.WriteLine("2 (as)Ошибка, объект нельзя преобразовать\n"); 
           }
           else { Console.WriteLine(you.Name); }
       }
 
   }
   class Implic_Explic
   {
        public struct Type
        {
            public int ds;
            public Type(int x)
            {
                this.ds = x;
            }
            public static explicit operator Type(int ds)
            {
                Type newvar = new Type(ds);
                return newvar;
            }
           
        }
        public struct Type2
        {
            public int df;
            public Type2(int f)
            {
                this.df = f;
            }
            public static implicit operator Type2(int f)
            {
                Type2 newdf = new Type2(f);
                return newdf;
            }
        }
        public static void Exes5()
        {
            int a = 332;
            int b = 111;
            Type newvar = (Type)a;
            Type2 newdf = b;
            Console.WriteLine($"Explicit:{newvar.ds}, Implicit:{newdf.df}\n");
        }
   }
    class Parse
    {
        static string v = "123";
        static int a = Convert.ToInt32(v);
        static int x = Int32.Parse(v);
        public static void Exes6()
        {
            Console.WriteLine($"{v} - {v.GetType()}");
            Console.WriteLine($"Convert: {a} - {a.GetType()}");
            Console.WriteLine($"Parse: {x} - {x.GetType()}");

            int br;
            int.TryParse(v, out br);
            Console.WriteLine($"TryParse: {br} - {br.GetType()}\n");
        }


    }
    class Programm
    {
        static void Main(string[] args)
        {
            Implicit.Exes1(5);
            Explicit.Exes2(6);
            Exception.Exes3(60000);
            As_n_is.Exes4();
            Implic_Explic.Exes5();
            Parse.Exes6();
        }
    }
  
}