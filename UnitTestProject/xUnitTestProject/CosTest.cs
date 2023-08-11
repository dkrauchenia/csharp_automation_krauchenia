using CSharpCalculator;

namespace xUnitTestProject
{
    public class CosTest
    {
        private Calculator calculator;

        public CosTest()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(Math.PI * 2, 1)]
        public void Cos_ReturnCorrectResult(double input, double expected)
        {
            double result = calculator.Cos(input);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("invlid_input")]
        public void Cos_ReturnException(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Cos(input));
        }
    }
}
