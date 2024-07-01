using Base.App;
using System.Net;

namespace Base.Test
{
    public class UnitTest1
    {
        private readonly Calculator _calculator;

        public UnitTest1()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void TestAdd_Success()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act
            int result = (int)_calculator.GetType().GetMethod("Addition").Invoke(_calculator, new object[] { a, b });

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAdd_Failure()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 20;

            // Act
            int result = (int)_calculator.GetType().GetMethod("Addition").Invoke(_calculator, new object[] { a, b });

            // Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void TestSubtract_Success()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expected = 5;

            // Act
            int result = (int)_calculator.GetType().GetMethod("Subtraction").Invoke(_calculator, new object[] { a, b });

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSubtract_Failure()
        {
            // Arrange
            int a = 10;
            int b = 5;
            int expected = 10;

            // Act
            int result = (int)_calculator.GetType().GetMethod("Subtraction").Invoke(_calculator, new object[] { a, b });

            // Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void TestMultiply_Success()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 50;

            // Act
            int result = (int)_calculator.GetType().GetMethod("Multiplication").Invoke(_calculator, new object[] { a, b });

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMultiply_Failure()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 25;

            // Act
            int result = (int)_calculator.GetType().GetMethod("Multiplication").Invoke(_calculator, new object[] { a, b });

            // Assert
            Assert.NotEqual(expected, result);
        }

        [Fact]
        public void TestDivide_Success()
        {
            // Arrange
            int a = 11;
            int b = 2;
            double expected = 5.5D;
            int remainderExpected = 1;

            // Act
            double result;
            double? remainder = null;
            object[] args = new object[] { a, b, remainder };
            result = (double)_calculator.GetType().GetMethod("Division").Invoke(_calculator, args);

            // Assert
            Assert.Equal(expected, result);
            Assert.Equal(Assert.IsType<double>(args[2]), remainderExpected);
        }

        [Fact]
        public void TestDivide_Failure()
        {
            // Arrange
            int a = 10;
            int b = 2;
            double expected = 10;

            // Act
            double result;
            double? remainder = null;
            object[] args = new object[] { a, b, remainder };
            result = (double)_calculator.GetType().GetMethod("Division").Invoke(_calculator, args);

            // Assert
            Assert.NotEqual(expected, result);
        }
    }
}