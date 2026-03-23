using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int n = int.Parse(Console.ReadLine());

            int m;
            int flag = 0;
            for (int i = 2; i <= n - 1; i++)
            {
                m = n % i;
                if (m == 0)
                {
                    Console.WriteLine("Not Prime Number:");
                    flag = 1;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("Prime no");
            }

        }
    }
}
