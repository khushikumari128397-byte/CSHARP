using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int min;
            Console.WriteLine("Enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            min = a[0];
            for (int i = 1; i < 5; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Maximum number =" + min);


        }
    }
}
