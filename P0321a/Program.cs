using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P0321a
{
    class Program
    {
        static void Main(string[] args)
        {

            // 讓使用者輸入 n，然後計算1+2+...+n的總和是多少？
            /*
            int n;         //使用者輸入的 n
            int total = 0; // 要用來儲存總和的變數
            Console.Write("n=");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                total += i;
            }

            Console.WriteLine($"1+2+...+{n}={total}");
            */
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
            Console.ReadLine();
        }
    }
}
