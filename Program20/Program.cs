using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Rectangle r1 = new Rectangle();
            r1.Calculate();
            r1.Display();
            Rectangle r2 = new Rectangle(30,40);
            r2.Calculate();
            r2.Display();

        }
    }
}
