using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int max;
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            max = a[0];
            for (int i = 1; i < 5; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Maximum number =" + max);


        }
    }
}
