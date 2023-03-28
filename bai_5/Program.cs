using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Nhap bat ky phim nao de tiep tuc, nhap phim Esc de thoat: ");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key==ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    DateTime thang;
                    Console.WriteLine("<--------------------------->");
                    if (NhapThang(out thang))
                    {
                        Console.WriteLine("Co {0} ngay trong thang", DateTime.DaysInMonth(thang.Year,thang.Month));
                    }
                    else { Console.WriteLine("Ban da nhap sai yeu cau"); }
                    Console.WriteLine("<--------------------------->");
                }
            }
        }
        static public bool NhapThang(out DateTime thang)
        {
            Console.Write("Nhap thang theo dinh dang MM/YYYY: ");
            string input = Console.ReadLine();
            bool test = DateTime.TryParseExact(input, "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out thang);
                return test;
        }
    }
}
