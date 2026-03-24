using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program21
{
    internal class Cars:Vehicle
    {
        string model_type, company_name;
        public void get_car()
        {
            Console.WriteLine("Enter model_type");
            model_type = Console.ReadLine();

            Console.WriteLine("Enter company_name");
            company_name = Console.ReadLine();
        }
        public void show_car()
        {
            Console.WriteLine("Model_Type " + model_type);
            Console.WriteLine("Company_Name " + company_name);
        }
    }
}
