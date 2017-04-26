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
            while (!int.TryParse(Console.ReadLine(), out Input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return Input;
        }

        public static int GetIntegerInRange(int Min, int Max)
        {
            int Input = GetValidInteger();
            while (Input < Min || Input > Max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Input not between {Min} and {Max}. Try again: ");
                Console.ForegroundColor = ConsoleColor.White;
                Input = GetValidInteger();
            }
            return Input;
        }
    }
}
