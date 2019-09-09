using System;
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

        public double Sum(double[] numbers)
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
            var mean = Mean(numbers);

            return Math.Sqrt(Sum(numbers.Select(x => (x - mean) * (x - mean)).ToArray()) / numbers.Length);
        }
    }
}
