using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compound Interest");
            Console.WriteLine("Enter Value of Principle:");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Rate of Interest");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of No of years");
            float n = float.Parse(Console.ReadLine());
            double amount = p * Math.Pow(1 + r/100,n);
            double compoundinterest = amount - p;
            Console.WriteLine("Compound Interest:" + compoundinterest);
        }
    }
}
