using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class ConsoleValidation
    {
        public static int GetValidInteger()
        {
            int Input;
            while (!int.TryParse(Console.ReadLine(), out Input)) //While user input is unable to be parsed into an integer, display error.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Input;
        }

        public static int GetIntegerInRange(int Min, int Max)
        {
            int Input = GetValidInteger(); //Gets a valid integer from user input
            while (Input < Min || Input > Max) //While input is less than the min or greater than the max, display an error.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Input not between {Min} and {Max}. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
                Input = GetValidInteger(); //Get another valid integer from the user if input is not in range.
            }
            return Input;
        }
    }
}
