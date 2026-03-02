using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interest");
            Console.WriteLine("Enter Value of Percentage:");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of Rate of Interest");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Value of No of years");
            float n = float.Parse(Console.ReadLine());
            float s = (p * r * n) / 100;
            Console.WriteLine("Simple Interest:" + s);

        }
    }
}
