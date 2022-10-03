using System;
using System.Threading;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(-20, -1, 5, -16)]
        [InlineData(0, 0, 0, 0)]
        [InlineData(5, 7, -100, -88)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object

            var calc = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = calc.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 3, 2)]//Add test data <-------
        [InlineData(0, -20, 20)]
        [InlineData(15, 7, 8)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Subtract(minuend, subtrahend);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(7, 11, 77)]//Add test data <-------
        [InlineData(0, 0, 0)]
        [InlineData(5, 0, 0)]
        [InlineData(0, 5, 0)]
        [InlineData(-5, -7, 35)]
        [InlineData(2, -2, -4)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(25, 5, 5)]//Add test data <-------
        [InlineData(13, 2, 6)]
        [InlineData(2, 5, 0)]
        [InlineData(16, 0, 0)]//following the example on the practice tests, dividing by zero returns zero for this method
        [InlineData(-4, -2, 2)]
        [InlineData(-12, 8, -1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var calc = new Calculator();

            //Act

            var actual = calc.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);

        }

    }
}
