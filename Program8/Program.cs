using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = 5; i >= 1; i--)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
