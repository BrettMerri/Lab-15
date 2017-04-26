using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class CountriesApp
    {
        public static int GetMenu()
        {
            Console.WriteLine("1.) See list of countries");
            Console.WriteLine("2.) Add a country");
            Console.WriteLine("3.) Exit");

            Console.Write("\nEnter menu number: ");

            return ConsoleValidation.GetIntegerInRange(1, 3);
        }
    }
}
