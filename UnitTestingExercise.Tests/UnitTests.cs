using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 2, 2, 6)]
        [InlineData(5,5,5,10)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var UnitTestMethods = new UnitTestMethods();
            //Act
            var actual = UnitTestMethods.Add(num1, num2, num3);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(10, 5, 6)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var UnitTestMethods = new UnitTestMethods();
            //Act
            var actual = UnitTestMethods.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(100, 10, 50)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var UnitTestMethods = new UnitTestMethods();
            //Act
            var actual = UnitTestMethods.Multiply(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Theory]
        [InlineData(100, 10, 10)]
        [InlineData(30, 2, 16)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var UnitTestMethods = new UnitTestMethods();
            //Act
            var actual = UnitTestMethods.Divide(num1, num2);
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void IsEven()
        {
            //Arrange
            var expected = true;
            //Act
            bool actual = true;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsOdd()
        {
            //Arrange
            var expected = true;
            //Act
            bool actual = false;
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
