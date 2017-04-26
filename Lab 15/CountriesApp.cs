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
            Console.WriteLine("1.) See list of countries"); //Writes a menu to the console for the user to choose from
            Console.WriteLine("2.) Add a country");
            Console.WriteLine("3.) Exit");

            Console.Write("\nEnter menu number: "); //Prompts user to enter a menu number

            return ConsoleValidation.GetIntegerInRange(1, 3); //Gets a validated integer input from the user that is between 1 and 3 and returns this integer.
        }
    }
}
