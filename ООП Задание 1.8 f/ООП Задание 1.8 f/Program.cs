using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ООП_Задание_1._8_f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int convto = 0;
            dynamic vvod;
            Console.WriteLine("Введите значение для конвертирования\n");
            vvod = Console.ReadLine();
            Console.WriteLine("В какой тип преобразовать?\n1 - int\n2- double\n3 - string\n4 - bool" +
            "\n5 - byte\n6 - decimal\n7 - float");
            convto = Convert.ToInt32(Console.ReadLine());


            switch (convto)
            {
                case 1:
                    {
                        try
                        {
                            vvod = Convert.ToInt32(vvod);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); return; }
                        break;
                    }
                case 2:
                    {
                        try
                        {
                            vvod = Convert.ToDouble(vvod);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); return; }
                        break;
                    }
                case 3:
                    {
                        try
                        {
                            vvod = Convert.ToString(vvod);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); return; }
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            vvod = Convert.ToBoolean(vvod);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); return; }
                        break;
                    }
                case 5:
                    {
                        try
                        {
                            vvod = Convert.ToByte(vvod);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); return; }
                        break;
                    }
                case 6:
                    {
                        try
                        {
                            vvod = Convert.ToDecimal(vvod);
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); return; }
                        break;
                    }
                case 7:
                    {
                        try
                        {
                            vvod = Convert.ToSingle(vvod);
                        }
                        catch (Exception ex){ Console.WriteLine(ex.Message);return; }
                        break;
                    }
                default:
                    Console.WriteLine("Введите число от 1 до 8 !!");
                    Console.ReadLine();
                    return;

            }

            Console.WriteLine($"Теперь значение {vvod} имеет значение {vvod.GetType()}");
            Console.ReadKey();


        }
    }
}
