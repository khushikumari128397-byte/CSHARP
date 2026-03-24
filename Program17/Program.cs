using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, temp, reminder;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while (temp != 0)
            {
                reminder = temp % 10;
                sum += reminder * reminder * reminder;
                temp /= 10;
            }
            if(sum == num)
            {
                Console.WriteLine(num + "is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(num + "is not an Armstrong number");
            }
        }
    }
}
