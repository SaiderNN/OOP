using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4_Задание_1
{
    internal class Program
    {
        struct Complex
        {
            public double Real;
            public double Imaginary;

            public Complex(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public double Modul
            {
                get { return Math.Sqrt(Real * Real + Imaginary * Imaginary); }
            }

            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
            }

            public static Complex operator -(Complex c1, Complex c2)
            {
                return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
            }

            public static Complex operator *(Complex c1, Complex c2)
            {
                return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
            }

            public static bool operator ==(Complex c1, Complex c2)
            {
                return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
            }

            public static bool operator !=(Complex c1, Complex c2)
            {
                return c1.Real != c2.Real && c1.Imaginary != c2.Imaginary; ;
            }

            public override string ToString()
            {
                return $"{Real} {(Imaginary < 0 ? "-" : "+")} {Math.Abs(Imaginary)}i";
            }
        }
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(2, 2);

            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"c2 = {c2}");

            Complex sum = c1 + c2;
            Console.WriteLine($"c1 + c2 = {sum}");

            Complex difference = c1 - c2;
            Console.WriteLine($"c1 - c2 = {difference}");

            Complex product = c1 * c2;
            Console.WriteLine($"c1 * c2 = {product}");

            Console.WriteLine($"|c1| = {c1.Modul}");
            Console.ReadLine();
        }
    }
}

