using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Nhap bat ky phim nao de tiep tuc, nhap phim Esc de thoat: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    int n;
                    if (NhapSoNguyen(out n, nameof(n)))
                    {
                        Console.WriteLine("<------------------------------------------->");
                        Console.WriteLine("Tong cac so nguyen duong tu 1 den n = {0}", Tong(n));
                        Console.WriteLine("<------------------------------------------->");
                    }
                    else
                        Console.WriteLine("n khong phai so nguyen duong");
                }
            }
        }
        static public bool NhapSoNguyen(out int x, string y)
        {
            Console.Write("\nNhap so nguyen duong {0} = ", y);
            bool test = int.TryParse(Console.ReadLine(), out x);
            if (test == true && x >= 0)
            {
                return true;
            }
            return false;
        }
        static public int Tong(int n)
        {
            int tong=0;
            for(int i = 0; i <= n; i++)
            {
                tong += i;
            }
            return tong;
        }
    }
}
