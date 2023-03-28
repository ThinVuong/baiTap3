using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Nhap bat ky phim nao de tiep tuc, nhap phim Esc đe thoat: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    int a;
                    if (NhapSoNguyen(out a, nameof(a)) == true)
                    {
                        Console.WriteLine("<--------------------------->");
                        chiaHetChoBa(a);
                        Console.WriteLine("<--------------------------->");
                    }
                }
            }
        }
        static public bool NhapSoNguyen(out int x, string y)
        {
            Console.Write("\n Nhap so nguyen {0} = ", y);
            bool test=int.TryParse(Console.ReadLine(), out x);
            if (test == false)
                Console.WriteLine("Day khong phai la so nguyen");
            return test;
        }
        static public void chiaHetChoBa(int x)
        {
            if (x%3==0)
                Console.WriteLine("a chia het cho 3");
            else
                Console.WriteLine("a khong chia het cho ba");
        }
    }
}
