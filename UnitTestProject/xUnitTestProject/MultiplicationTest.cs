using CSharpCalculator;

namespace xUnitTestProject
{
    public class MultiplicationTest
    {
        private Calculator calculator;

        public MultiplicationTest()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(2.0, 3.0, 6.0)]
        [InlineData(-2.0, -3.0, 6.0)]
        public void Multiply_ReturnCorrectResult(double a, double b, double expected)
        {
            double result = calculator.Multiply(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3.3, 0.0)]
        public void Multiply_ReturnZero(double a, double b)
        { 
            double result = calculator.Multiply(a, b);
            Assert.Equal(0.0, result);
        }

        [Theory]
        [InlineData("aaa", "bbb")]
        public void Multiply_ReturnException(object a, object b)
        {
            Assert.Throws<InvalidCastException>(() => calculator.Multiply((double)a, (double)b));
            
        }

    }
}