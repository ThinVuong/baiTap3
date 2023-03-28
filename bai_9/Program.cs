using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_9
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
                        Console.WriteLine("Ve tam giac sao(*) {0} dong (*):\n{1}", nameof(n), Tamgiac(n));
                        Console.WriteLine("Ve tam giac can sao(*) {0} dong (*):\n{1}", nameof(n), TamgiacCan(n));
                        Console.WriteLine("Ve tam giac nguoc sao(*) {0} dong (*):\n{1}", nameof(n), TamgiacNguoc(n));
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
        static public string Tamgiac(int x)
        {
            string hang = "";
            string hangSau = "";
            for (int i = 1; i <= x; i++)
            {
                hangSau +="*";
                hang += "\n" + hangSau;
            }

            return hang;
        }
        static public string TamgiacCan(int x)
        {
            string hang = "";
            string hang1 = "";
            string hang2 = "";
            for (int i = 1; i <= x; i++)
            {
                for(int j=x-i-1;j>=0;j--)
                {
                    hang2 = hang2+" ";
                }
                hang1 +="* ";
                hang +="\n" +hang2+hang1;
                hang2 = "";
            }

            return hang;
        }
        static public string TamgiacNguoc(int x)
        {
            string hang = "";
            string hang1 = "";
            string hang2 = "";
            for (int i = 1; i <= x; i++)
            {
                for (int k = 1; k <= i-1; k++)
                {
                    hang2 = hang2 + " ";
                }
                for (int j = x-i; j >= 0; j--)
                {
                    hang1 = hang1 + "* ";
                }
                hang += "\n" + hang2 + hang1;
                hang2 = "";
                hang1 = "";
            }

            return hang;
        }
    }
}
