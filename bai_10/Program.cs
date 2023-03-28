using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_10
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
                    Console.Clear();
                    int n;
                    if (NhapSoNguyenDuong(out n, nameof(n)))
                    {
                        Console.WriteLine("<------------------------------->");
                        Console.WriteLine("DayFibonacci tu 1 den {0} la: {1}", nameof(n), SoNguyenTo(n));
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
        static public string SoNguyenTo(int x)
        {
            string result = "";
            int j = 0;
            int k = 0;
            int l = 0;

            while (j<=x)
            {
                result =(j==0)? "0": $"{result}, {j}";
                if (j == 0)
                {
                    j = 1;
                }
                else
                {
                    l = k;
                    k = j;
                    j += l;
                }
            }
            return result;
        }
    }
}
