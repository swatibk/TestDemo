using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using BusinessLayer;

namespace TestApplication.xUnit
{
    public class CalculatorBL_Test
    {
        #region Add Test Methods
        [Fact]
        public void AddTest()
        {
            var number1 = 10;
            var number2 = 20;
            var expected = 30;

            CalculatorBL calculator = new CalculatorBL();
            var result = calculator.Add(number1, number2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 10, 20)]
        [InlineData(20, 20, 40)]
        public void AddTest(int number1, int number2, int expected)
        {
            CalculatorBL calculator = new CalculatorBL();
            var result = calculator.Add(number1, number2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FailingAddTest()
        {
            CalculatorBL calculator = new CalculatorBL();
            Assert.Equal(5, calculator.Add(2, 2));
        }

        # endregion

        #region Subtract Test Method

        [Fact]
        public void SubtractTest()
        {
            var number1 = 6;
            var number2 = 5;
            var expected = 1;

            CalculatorBL calculator = new CalculatorBL();
            var result = calculator.Subtract(number1, number2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 10, 0)]
        [InlineData(20, 15, 5)]
        public void SubtractTest(int number1, int number2, int expected)
        {
            CalculatorBL calculator = new CalculatorBL();
            var result = calculator.Subtract(number1, number2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FailingSubtractTest()
        {
            CalculatorBL calculator = new CalculatorBL();
            Assert.Equal(1, calculator.Subtract(2, 2));
        }

        #endregion

        #region Multiplication Test Method

        [Fact]
        public void MultiplicationTest()
        {
            var number1 = 6;
            var number2 = 5;
            var expected = 30;

            CalculatorBL calculator = new CalculatorBL();
            var result = calculator.Multiply(number1, number2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 6, 30)]
        [InlineData(5, 5, 25)]
        [InlineData(4, 6, 25)]
        [InlineData(4, 8, 25)]
        [InlineData(4, 7, 25)]
        public void MultiplicationTest(int number1, int number2, int expected)
        {
            CalculatorBL calculator = new CalculatorBL();
            var result = calculator.Multiply(number1, number2);

            Assert.InRange(result, 25, 30);
        }

        [Fact]
        public void FailingMultiplicationTest()
        {
            CalculatorBL calculator = new CalculatorBL();
            Assert.Equal(3, calculator.Multiply(2, 2));
        }

        #endregion
    }
}
