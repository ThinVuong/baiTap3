using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nNhap bat ky phim nao de tiep tuc, nhap phim Esc de thoat: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    int x;
                    if (NhapSoNguyenDuong(out x, nameof(x)))
                    {
                        Console.WriteLine("<----------------------->");
                        if (SoChinhPhuong(x))
                        {
                            Console.WriteLine("{0} la so chinh phuong", nameof(x));
                        }
                        else
                            Console.WriteLine("{0} khong phai so chinh phuong", nameof(x));
                        Console.WriteLine("<----------------------->");
                    }
                    else { Console.WriteLine("So ban vua nhap khong phai la so nguyen duong"); }
                }
            }
        }
        static public bool NhapSoNguyenDuong(out int x, string y)
        {
            Console.Write("\nNhap so nguyen {0} = ", y);
            bool test = int.TryParse(Console.ReadLine(), out x);
            if (test && x>=0) 
            {
                return true;
            }
            else { return false; }
        }
        static public bool SoChinhPhuong(int x)
        {
            return Math.Sqrt(x)%1== 0;
        }
    }
}
