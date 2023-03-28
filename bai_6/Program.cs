using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Danh phim bat ky de tiep tuc, nhan phim Esc de thoat: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key==ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    int n;
                    Console.WriteLine("<------------------------------->");
                    if(NhapSoNguyenDuong(out n, nameof(n)))
                    {
                        Console.WriteLine("Tong S la: S = {0}",TongS(n));
                    }
                    else { Console.WriteLine("Ban nhap khong dung yeu cau"); }
                    Console.WriteLine("<------------------------------->");
                }
            }
            
        }
        static public bool NhapSoNguyenDuong(out int x, string y)
        {
            Console.Write("\nNhap so nguyen duong lon hon 0 {0} = ", y);
            bool test = int.TryParse(Console.ReadLine(), out x);
            if (x > 0 && test)
                return true; else return false;
        }
        static public int TongS(int x)
        {
            int tong = 0;
            for(int i=1; i<=x; i++)
            {
                tong += (int) Math.Pow(i, i);
            }
            return tong;
        }

    }
}
