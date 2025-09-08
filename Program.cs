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
