using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program24
{
    internal class Triangle: Shape
    {
        private double baseValue;
        private double height;

        public Triangle(double b, double h)
        {
            baseValue = b;
            height = h;
        }

        public override double Area()
        {
            return 0.5 * baseValue * height;
        }
    }
}
