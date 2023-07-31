using CSharpCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitTestProject
{
    public class SquareRootTest
    {
        private Calculator calculator;

        public SquareRootTest()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(4, 2)]
        [InlineData(16, 4)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        public void Sqrt_ReturnCorrectResult(int number, int expected)
        {
            var result = calculator.Sqrt(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("invalid_input")]
        public void Sqrt_ReturnException(object a)
        {
            Assert.Throws<FormatException>(() => calculator.Sqrt(a));
        }
    }
}
