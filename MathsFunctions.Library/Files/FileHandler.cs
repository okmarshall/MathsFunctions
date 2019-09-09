using System;
using System.IO;

namespace MathsFunctions.Library.Files
{
    public class FileHandler
    {
        public string[] CsvFileToArray(string path)
        {
            string[] stringArray;

            using (var reader = new StreamReader("SampleData.csv"))
            {
                var line = reader.ReadLine();
                stringArray = line.Split(",");
            }

            return stringArray;
        }
    }
}
