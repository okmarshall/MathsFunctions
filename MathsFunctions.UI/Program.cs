using System;
using MathsFunctions.Library;
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
                var functions = new Functions();

                var stringArray = fileHandler.CsvFileToArray("SampleData.csv");

                var numbers = Array.ConvertAll(stringArray, decimal.Parse);

                var mean = functions.Mean(numbers);

                Console.WriteLine($"Mean: {mean}");
            }
            catch(Exception)
            {
                Console.WriteLine("There was an error...");
            } 
        }
    }
}
