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
            StreamWriter sw = new StreamWriter(FilePath, true);
            sw.WriteLine(Input);
            sw.Close();
        }
        public static string Read(string FilePath)
        {
            StreamReader rd = new StreamReader(FilePath);
            string FileContent = rd.ReadToEnd();
            rd.Close();
            return FileContent;
        }
    }
}
