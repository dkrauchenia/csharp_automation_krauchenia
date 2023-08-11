using CSharpCalculator;

namespace xUnitTestProject
{
    public class SinTest
    {
        private Calculator calculator;

        public SinTest()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(Math.PI/2, 1)]
        public void Sin_ReturnCorrectResult(double input, double expected)
        {
            double result = calculator.Sin(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("invlid_input")]
        public void Sin_ReturnException(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sin(input));
        }
    }

}

