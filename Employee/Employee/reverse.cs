using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class reverse
    {
        public static void FindThePerfectNumber()
        {
            int num, sum, mn, mx;
            Console.WriteLine("Finding perfect numbers in given series");
            Console.WriteLine("Input the starting range");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("perfect numbers are:");

            for (num = mn; num <= mx; num++)
            {
                int i = 1;
                sum = 0;
                while (i < num)
                {
                    if (num % i == 0)
                        sum += 1;
                    i++;
                }
                if (sum == num)
                    Console.Write(num + " ");
            }
        }
    }

}

