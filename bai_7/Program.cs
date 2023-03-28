using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Danh mot phim bat ky de tiep tuc hoac danh phim Esc de thoat: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    int n;
                    if(NhapSoNguyenDuong(out n,nameof(n)))
                    {
                        Console.WriteLine("<------------------------------->");
                        Console.WriteLine("Tong cac so le la: {0}", TongLe(n));
                        Console.WriteLine("<------------------------------->");
                    }
                    else { Console.WriteLine("So ban vua nhap khong dung yeu cau"); }

                }
            }
        }
        static public bool NhapSoNguyenDuong(out int x, string y)
        {
            Console.Write("\nNhap so nguyen duong lon hon 0 {0} = ", y);
            bool test = int.TryParse(Console.ReadLine(), out x);
            if (x > 0 && test)
                return true;
            else return false;
        }
        static public int TongLe(int x)
        {
            int tong = 0;
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                    tong += i;
            }
            return tong;
        }
    }
}
