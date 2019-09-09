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

                var array = fileHandler.CsvFileToArray("SampleData.csv");

                var numbers = Array.ConvertAll(array, double.Parse);

                var mean = functions.Mean(numbers);

                var standardDeviation = functions.StandardDeviation(numbers);

                Console.WriteLine($"Mean: { mean }");
                Console.WriteLine($"Standard Deviation: { standardDeviation }");
            }
            catch(Exception)
            {
                Console.WriteLine("There was an error...");
            } 
        }
    }
}
