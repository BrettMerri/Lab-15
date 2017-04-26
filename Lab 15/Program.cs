using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            string FilePath = "../../Countries.txt";
            bool Loop = true;

            while (Loop)
            {
                int MenuSelection = CountriesApp.GetMenu();

                if (MenuSelection == 1)
                    Console.WriteLine(CountriesTextFile.Read(FilePath));
                else if (MenuSelection == 2)
                {
                    Console.Write("\nEnter country: ");
                    string NewCountry = Console.ReadLine();
                    CountriesTextFile.Write(NewCountry, FilePath);
                    Console.WriteLine("This country has been saved!\n");
                }
                else
                    Loop = false;
            }
        }
    }
}
