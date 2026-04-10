using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program26
{
    class Result : Exam, Classify
    {
        public bool Pass(int mark)
        {
            return mark >= 50;
        }

        public string Division(int average)
        {
            if (average >= 60)
                return "First";
            else if (average >= 50)
                return "Second";
            else
                return "No division";
        }
    }
}
