using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                Console.Clear();
                Console.Write("Xuat day Fibonacci voi n phan tu: (n)= ");
                uint n = uint.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine($"-> Day Fibonacci voi {n} phan tu la: ");
                DayFibonacci(n);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim BAT KY de tiep tuc / phim ESC de ket thuc");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
        static void DayFibonacci(uint soNguyen)
        {
            double a = 0;
            double b = 1;
            double c;
            for (uint i = 1; i <= soNguyen; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write($"0\t");
                        break;
                    case 2:
                        Console.Write($"1\t");
                        break;
                    default:
                        c = a + b;
                        Console.Write($"{c}\t");
                        a = b;
                        b = c;
                        break;
                }
            }
        }
    }
}