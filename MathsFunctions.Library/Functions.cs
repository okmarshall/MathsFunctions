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

        public double Sum(IEnumerable<double> numbers)
        {
            double total = 0;

            foreach (var number in numbers)
            {
                total += number;
            }

            return total;
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
    }
}
