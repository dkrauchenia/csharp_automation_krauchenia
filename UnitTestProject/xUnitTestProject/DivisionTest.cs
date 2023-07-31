using CSharpCalculator;

namespace xUnitTestProject
{
    public class DivisionTest
    {
        private Calculator calculator;

        public DivisionTest()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(8.0, 4.0, 2.0)]
        [InlineData(-6.0, -2.0, 3.0)]
        [InlineData(0.0, 10.0, 0.0)]
        public void Divide_ReturnCorrectResult(double a, double b, double expected)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(8.0, double.NaN)]
        [InlineData(double.NaN, -3)]
        public void Divide_ReturnNaN(double a, double b)
        {
            Calculator calculator = new Calculator();
            double result = calculator.Divide(a, b);
            Assert.True(double.IsNaN(result));
        }
        
    }
}
