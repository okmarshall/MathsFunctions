using System;
using MathsFunctions.Library.Files;

namespace MathsFunctions.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fileHandler = new FileHandler();

                var stringArray = fileHandler.CsvFileToArray("SampleData.csv");

                var numbers = Array.ConvertAll(stringArray, decimal.Parse);
            }
            catch(Exception ex)
            {
                
            } 
        }
    }
}
