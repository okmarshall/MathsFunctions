using System;
using System.Linq;
using MathsFunctions.Library;
using NUnit.Framework;

namespace Tests
{
    public class FunctionsTests
    {
        [Test]
        public void When_An_Empty_Array_Is_Passed_To_Mean_Then_An_Argument_Exception_Is_Thrown()
        {
            var functions = new Functions();
            var numbers = new double[] { };

            Assert.Throws<ArgumentException>(() => functions.Mean(numbers));
        }

        [Test]
        public void When_Null_Is_Passed_To_Mean_Then_An_Argument_Exception_Is_Thrown()
        {
            var functions = new Functions();
            double[] numbers = null;

            Assert.Throws<ArgumentException>(() => functions.Mean(numbers));
        }

        [Test]
        public void When_An_Empty_Array_Is_Passed_To_Sum_Then_Zero_Is_Returned()
        {
            var functions = new Functions();
            var numbers = new double[] { };

            var sum = functions.Sum(numbers);

            Assert.AreEqual(0, sum);
        }

        [Test]
        public void When_An_Array_Of_Doubles_Is_Passed_To_Sum_Then_The_Correct_Sum_Is_Returned()
        {
            var functions = new Functions();
            var numbers = new double[] { 1.21, 2.35, 0.76 };

            var sum = functions.Sum(numbers);

            Assert.AreEqual(4.32, sum);
        }

        [Test]
        public void When_An_Empty_Array_Is_Passed_To_Standard_Deviation_Then_An_Argument_Exception_Is_Thrown()
        {
            var functions = new Functions();
            var numbers = new double[] { };

            Assert.Throws<ArgumentException>(() => functions.StandardDeviation(numbers));
        }

        [Test]
        public void When_A_Null_Array_Is_Passed_To_Standard_Deviation_Then_An_Argument_Exception_Is_Throw()
        {
            var functions = new Functions();
            double[] numbers = null;

            Assert.Throws<ArgumentException>(() => functions.StandardDeviation(numbers));
        }

        [Test]
        public void When_An_Array_Of_Doubles_Is_Passed_To_Standard_Deviation_Then_The_Correct_Standard_Deviation_Is_Returned()
        {
            var functions = new Functions();
            var numbers = new double[] { 1.21, 2.35, 0.76 };

            var standardDeviation = functions.StandardDeviation(numbers);

            Assert.AreEqual(0.66918, Math.Round(standardDeviation, 5));
        }

        [Test]
        public void When_An_Array_Of_Doubles_Is_Passed_To_Calculate_Frequency_Bins_Then_The_Correct_Frequency_Bins_Are_Returned()
        {
            var functions = new Functions();
            var numbers = new double[]
            {
                5,
                10, 11,
                20, 21, 22,
                30, 31, 32, 33,
                40, 41, 42, 43, 44,
                50, 51, 52, 53, 54, 55,
                60, 61, 62, 63, 64, 65, 66,
                70, 71, 72, 73, 74, 75, 76, 77,
                80, 81, 82, 83, 84, 85, 86, 87, 88,
                90, 91, 92, 93, 94,95, 96, 97, 98, 99
            };

            var bins = functions.CalculateFrequencyBins(numbers).OrderBy(b => b.LowerBound).ToArray();

            Assert.Multiple(() =>
            {
                Assert.AreEqual(bins[0].Frequency, 1);
                Assert.AreEqual(bins[1].Frequency, 2);
                Assert.AreEqual(bins[2].Frequency, 3);
                Assert.AreEqual(bins[3].Frequency, 4);
                Assert.AreEqual(bins[4].Frequency, 5);
                Assert.AreEqual(bins[5].Frequency, 6);
                Assert.AreEqual(bins[6].Frequency, 7);
                Assert.AreEqual(bins[7].Frequency, 8);
                Assert.AreEqual(bins[8].Frequency, 9);
                Assert.AreEqual(bins[9].Frequency, 10);
            });
        }
    }
}