using System;
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
    }
}