using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0321a
{
    class Program
    {
        static void Practice1()
        {
            // 讓使用者輸入 n，然後計算1+2+...+n的總和是多少？
            int n;         //使用者輸入的 n
            int total = 0; // 要用來儲存總和的變數
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                total += i;
            }

            Console.WriteLine($"1+2+...+{n}={total}");
        }

        static void Practice2()
        {
            // 讓使用者輸入 n，然後計算1*2*...*n的階乘值是多少？
            int n;         //使用者輸入的 n
            long total = 1; // 要用來儲存階乘的變數
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                total *= i;
            }

            Console.WriteLine($"{n}!={total}");
        }

        static void Practice3()
        {
            // 讓使用者輸入 n (n>1)，判斷n是否為質數 

            int n;         //使用者輸入的 n
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{n}是質數！");
            }
            else
            {
                Console.WriteLine($"{n}不是質數！");
            }

        }
        static void Main(string[] args)
        {
            Practice3();
            Console.ReadLine();
        }
    }
}
