using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
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
                    int n;
                    if (NhapSoNguyen(out n, nameof(n)))
                    {
                        Console.WriteLine("<------------------------------>");
                        Console.WriteLine(bangCuuChuong(n));
                        Console.WriteLine("<------------------------------>");
                    }
                    else 
                        Console.WriteLine("n phai la so nguyen"); 
                }
            }
        }
        static public bool NhapSoNguyen(out int x, string y)
        {
            Console.Write("\nNhap so nguyen {0} = ", y);
            return int.TryParse(Console.ReadLine(), out x);
        }
        static public string bangCuuChuong(int n)
        {
            if (n <= 0)
            {
                return "n phai lon hon hoac bang 0";
            }
            else
            {
                Console.WriteLine("Bang cuu chuong tu 1 den {0}:", n);
                string BCC = String.Empty;
                for (int i = 1; i <= n; i++)
                {
                    BCC += (i == 1) ? $"Nhan voi {i}:" : $"\nNhan voi {i}";
                    for (int j = 1; j <= 10; j++)
                    {
                        BCC += $"\n\t{i} * {j} = {i * j}";
                    }
                }
                return BCC;
            }
        }
    }
}
