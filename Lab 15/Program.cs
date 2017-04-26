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
            Console.BackgroundColor = ConsoleColor.Black; //Set default console colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Lab 15 - Countries Maintenance Application"; //Set console title

            string FilePath = "../../Countries.txt"; //Declare path to Countries.txt
            bool Loop = true; //Set Loop to true

            while (Loop) //Loops application until Loop is set to false
            {
                int MenuSelection = CountriesApp.GetMenu(); //Lists a menu and prompts user input. returns user's selection to MenuSelection

                if (MenuSelection == 1) //If user inputs 1 for "See the list of countries"
                    Console.WriteLine(CountriesTextFile.Read(FilePath)); //Writes the contents of the Countries.txt file to the console
                else if (MenuSelection == 2) //If user inputs 2 for "Add a country"
                {
                    Console.Write("\nEnter country: "); //Prompts use to enter a country
                    string NewCountry = Console.ReadLine(); //Set NewCountry to the user's input
                    CountriesTextFile.Write(NewCountry, FilePath); //Appends NewCountry to the Countries.txt file
                    Console.WriteLine("This country has been saved!\n"); //Informs the user that the country has been saved successfully.
                }
                else //If user inputs 3 for "Exit"
                {
                    Console.WriteLine("\nByebye!\n"); //Write a goodbye message to the console.
                    Loop = false;  //Set loop to false to no longer loop the application and "exit"
                }
            }
        }
    }
}
