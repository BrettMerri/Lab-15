using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_15
{
    class CountriesTextFile
    {
        public static void Write(string Input, string FilePath)
        {
            StreamWriter sw = new StreamWriter(FilePath, true); //Creates new StreamWriter object that appends a string to a text file.
            sw.WriteLine(Input); //Writes an input to the file and creates a new line at the end
            sw.Close(); //Closes the StreamWriter
        }
        public static string Read(string FilePath)
        {
            StreamReader rd = new StreamReader(FilePath); //Creates new StreamReader object that reads the contents of a text file.
            string FileContent = rd.ReadToEnd(); //Reads the whole text file and sends the text to FileContent
            rd.Close(); //Closes the StreamReader
            return FileContent; //Returns the string containing the contents of the text file
        }
    }
}
