﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_8
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
                        Console.WriteLine("Cac so nguyen to tu 1 den {0} la: {1}", nameof(n), SoNguyenTo(n));
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
            bool laSNT = true;
            string result = "2";
            for (int i = 3; i <= x; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        laSNT = false;
                        break;
                    }
                }
                    result =(laSNT)? $"{result}, {i}": result;
                laSNT=  true;
            }
            return result;
        }
    }
}
