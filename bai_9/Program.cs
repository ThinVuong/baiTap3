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
                        Console.WriteLine("Ve tam giac sao(*) {0} 2 dong (*):\n{1}", nameof(n), Tamgiac2(n));
                        Console.WriteLine("Ve tam giac can sao(*) {0} dong (*):\n{1}", nameof(n), TamgiacCan(n));
                        Console.WriteLine("Ve tam giac can sao(*) 2 {0} dong (*):\n{1}", nameof(n), TamgiacCan2(n));
                        Console.WriteLine("Ve tam giac nguoc sao(*) {0} dong (*):\n{1}", nameof(n), TamgiacNguoc(n));
                        Console.WriteLine("Ve tam giac nguoc sao(*) 2 {0} dong (*):\n{1}", nameof(n), TamgiacNguoc2(n));
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
        static public string Tamgiac2(int x)
        {
            string hang = "";
            string hang1 = "";
            string hang2 = "";
            for (int i = 1; i <= x; i++)
            {
                hang1 += " ";
                for (int j = x - i; j > 0; j--)
                    hang2 += "*";
                hang += "\n" + hang1 + hang2;
                hang2 = "";
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
        static public string TamgiacCan2(int x)
        {
            string hang = "";
            string hang1 = "";
            string hang2 = "";
            string hang3 = "";
            for (int i = 1; i <= x; i++)
            {
                for (int j = x - i; j >= 1; j--)
                {
                    hang2 = hang2 + "*";
                }
                hang1 += " ";
                for(int k=0; k <= i-2; k++)
                { hang3 += " "; }
                hang +=(i==1)? "\n" + hang2 + hang1 + hang2 : "\n" + hang2 + hang1 + hang3 +hang2;
                hang2 = "";
                hang3 = "";
            }

            return hang;
        }
        static public string TamgiacNguoc2(int x)
        {
            string hang = "";
            string hang1 = "";
            string hang2 = "";
            for (int i = 1; i <= x; i++)
            {
                for (int k = 1; k <= i - 1; k++)
                {
                    hang2 = hang2 + "*";
                }
                for (int j = (x-i)*2+1; j >= 1; j--)
                {
                    hang1 = hang1 + " ";
                }
                hang += "\n" + hang2 + hang1 +hang2;
                hang2 = "";
                hang1 = "";
            }

            return hang;
        }
    }
}
