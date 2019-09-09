using System;
using System.Collections.Generic;
using System.Linq;

namespace MathsFunctions.Library
{
    public class Functions
    {
        public double Mean(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Cannot calculate the mean of a zero-length array!");

            var total = Sum(numbers);

            return total / numbers.Length;
        }

        public double StandardDeviation(double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Cannot calculate the standard deviation of a zero-length array!");

            var mean = Mean(numbers);

            var numbersWithMeanSubtracted = numbers.Select(n => n - mean);

            var numbersWithMeanSubtractedAndSquared = numbersWithMeanSubtracted.Select(n => n * n);

            var variance = Sum(numbersWithMeanSubtractedAndSquared) / numbers.Length;

            return Math.Sqrt(variance);
        }

        public FrequencyBin[] CalculateFrequencyBins(double[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
                throw new ArgumentException("Cannot calculate the frequency distribution of a zero-length array!");
                
            var bins = CreateFrequencyBins();

            foreach (var number in numbers)
            {
                var bin = bins.First(b => b.LowerBound <= number && b.UpperBound > number);

                bin.Frequency += 1;
            }

            return bins;
        }

        private double Sum(IEnumerable<double> numbers)
        {
            double total = 0;

            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
        }

        private FrequencyBin[] CreateFrequencyBins()
        {
            return new FrequencyBin[]
            {
                new FrequencyBin() { LowerBound = 0, UpperBound = 10 },
                new FrequencyBin() { LowerBound = 10, UpperBound = 20 },
                new FrequencyBin() { LowerBound = 20, UpperBound = 30 },
                new FrequencyBin() { LowerBound = 30, UpperBound = 40 },
                new FrequencyBin() { LowerBound = 40, UpperBound = 50 },
                new FrequencyBin() { LowerBound = 50, UpperBound = 60 },
                new FrequencyBin() { LowerBound = 60, UpperBound = 70 },
                new FrequencyBin() { LowerBound = 70, UpperBound = 80 },
                new FrequencyBin() { LowerBound = 80, UpperBound = 90 },
                new FrequencyBin() { LowerBound = 90, UpperBound = 100 }
            };
        }
    }
}
