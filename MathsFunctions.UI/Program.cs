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
                var numbers = GetNumberArray();

                var functions = new Functions();

                var mean = functions.Mean(numbers);

                var standardDeviation = functions.StandardDeviation(numbers);

                var frequencyBins = functions.CalculateFrequencyBins(numbers);

                Console.WriteLine($"Mean: { mean }");

                Console.WriteLine($"Standard Deviation: { standardDeviation }");

                foreach (var bin in frequencyBins)
                {
                    Console.WriteLine($"Min:{ bin.Minimum }, Max:{ bin.Maximum }, Freq:{ bin.Frequency }");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("There was an error...");
            } 
        }

        private static double[] GetNumberArray()
        {
            var fileHandler = new FileHandler();

            var array = fileHandler.CsvFileToArray("SampleData.csv");

            return Array.ConvertAll(array, double.Parse);
        }
    }
}
