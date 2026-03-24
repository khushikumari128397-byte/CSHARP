using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program20
{
    internal class Rectangle
    {
        int l, w, area;
        public Rectangle()
        {
            l = 10;
            w = 20;
        }
        public Rectangle(int l1, int w1)
        {
            l = l1;
            w = w1;
        }
        public void Calculate()
        {
            area = l * w;
        }
        public void Display()
        {
            Console.WriteLine("Area:" +area);
        }


    }
}
