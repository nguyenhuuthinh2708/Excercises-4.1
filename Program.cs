using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Excercises_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập lựa chọn\n\t1: Tìm số lớn nhất trong ba số\n\t2: Tìm số lớn nhất trong dãy số nhận ít nhất 1 tham số\n\t3: Tính giai thừa\n\t4: Số nguyên tố\n\t5: In ra các số nguyên tố nhỏ hơn\n\t6: In ra N số nguyên tố đầu tiên\n\t7: Kiểm tra số hoàn hảo\n\t8: In tất cả số hoàn hảo nhỏ hơn 1000\n\t9: Kiểm tra chuỗi pangram ");
            int choice = 0;
            string s = Console.ReadLine();
            while (!int.TryParse(s, out choice))
            {
                Console.WriteLine("Nhập lại");
                s = Console.ReadLine();
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhập 3 số");
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    int z = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Số lớn nhất trong 3 số là {MaxOfNums(x,y,z)}");
                    break;
                case 2:
                    Console.WriteLine($"Số lớn nhất trong các số là {LargestNums(1,23,44,43,55,654)}");
                    break;
                case 3:
                    Console.WriteLine("Nhập số muốn tính giai thừa: ");
                    int so = 0;
                    string t = Console.ReadLine() ;
                    while (!int.TryParse(t, out so))
                    {
                        Console.WriteLine("Nhập lại");
                        t = Console.ReadLine() ;
                    }
                    Console.WriteLine($"{so}! = {GiaiThua(so)}");
                    break ;
                case 4:
                    Console.WriteLine("Nhập số muốn tính giai thừa: ");
                    int n = 0;
                    string u = Console.ReadLine();
                    while (!int.TryParse(u, out n))
                    {
                        Console.WriteLine("Nhập lại");
                        u = Console.ReadLine();
                    }
                    if (LaNguyento(n))
                    {
                        Console.WriteLine($"{n} là số nguyên tố");
                    }
                    else
                    {
                        Console.WriteLine($"{n} không phải là số nguyên tố");
                    }
                    break;
                case 5:
                    Console.WriteLine("Nhập số ");
                    int h = 0;
                    string j = Console.ReadLine(); 
                    while (!int.TryParse(j, out h))
                    {
                        Console.WriteLine("Nhập lại ");
                        j = Console.ReadLine();
                    }
                    Console.WriteLine($"Các số nguyên tố bé hơn {h} là: "); SoNguyentoBe(h);
                    break;
                case 6:
                    Console.WriteLine("Nhập số lượng số nguyên tố");
                    int f = 0;  
                    string g = Console.ReadLine();
                    while (!int.TryParse(g, out f))
                    {
                        Console.WriteLine("Nhập lại");
                        g = Console.ReadLine(); 
                    }
                    Console.WriteLine($"{f} Số nguyên tố đầu tiên là "); NSoNguyentoDautien(f);
                    break;
                case 7:
                    Console.WriteLine("Nhập số");
                    int k = 0;
                    string l = Console.ReadLine();  
                    while (!int.TryParse(l, out k))
                    {
                        Console.WriteLine("Nhập lại");
                        l = Console.ReadLine();
                    }
                    if (SoHoanhao(k))
                    {
                        Console.WriteLine($"{k} là số hoàn hảo");
                    }
                    else
                    {
                        Console.WriteLine($"{k} không phải là số hoàn hảo");
                    }
                        break;
                case 8:
                    Console.WriteLine("Số hoàn hảo bé hơn 1000 là:");
                    SoHoanhaoBehon1000();
                    break;
                case 9:
                    Console.WriteLine("Nhập chuỗi");
                    string r =  Console.ReadLine();
                    if (LaPangram(r))
                    {
                        Console.WriteLine("Chuỗi của bạn là Pangram");
                    }
                    else
                    {
                        Console.WriteLine("Chuỗi của bạn không phải Pangram");
                    }
                    break;

            }
            

        }
        //Bài 1.1: Tìm số lớn nhất trong ba số
        static int MaxOfNums(int a,int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));
            return max;
        }
        //Bài 1.2: Tìm số lớn nhất trong dãy số nhận ít nhất 1 tham số:
        static int LargestNums (params int[] nums)
        {
            int max = nums[0];
            foreach (int num in nums)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        //Bài 2: Tính giai thừa
        static int GiaiThua ( int n )
        {
            int giaithua = 1;
            for (int i = 1; i<= n; i++)
            {
                giaithua *= i;
            }
            return giaithua;
        }
        //Bài 3: Số nguyên tố
        static bool LaNguyento ( int n )
        {
            bool laNguyento = true;
            if ( n < 2 ) 
                laNguyento = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if ( n %  i == 0 )
                {
                    laNguyento = false;
                    break;
                }
            } 
            return laNguyento;

        }
        // Bài 4.1: In ra các số nguyên tố nhỏ hơn 
        static  void SoNguyentoBe ( int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (LaNguyento(i))
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }
        // Bài 4.2: In ra N số nguyên tố đầu tiên 
        static void NSoNguyentoDautien ( int n)
        {
            int dem = 0, So = 2;
           while ( dem < n)
            {
                if (LaNguyento(So))
                {
                    Console.WriteLine($"{So} ");
                    dem++;
                }
                So++;
            }
        }
        // Bài 5.1: Kiểm tra số hoàn hảo:
        static bool SoHoanhao (int n)
        {
            int tong = 0;
            bool laHoanhao = false;
            for ( int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    tong += i;
                }
            }
            if (tong == n)
            {
                laHoanhao = true;
            }
            return laHoanhao;
        }
        // Bài 5.2: In tất cả số hoàn hảo nhỏ hơn 1000
        static void SoHoanhaoBehon1000 ()
        {
            for ( int i = 1; i < 1000; i++)
            {
                if (SoHoanhao(i))
                {
                    Console.WriteLine($"{i} ");
                }

            }
        }
        // Bài 6: Kiểm tra chuỗi pangram 
        static bool LaPangram (string n)
        {
            bool laPangram = true;
            n = n.ToLower();
            for (char i = 'a'; i <= 'z'; i++)
            {
                if (!n.Contains(i))
                {
                   laPangram = false;
                }
            }
            return laPangram;
        }
    }
}
