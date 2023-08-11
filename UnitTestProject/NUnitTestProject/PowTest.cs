using CSharpCalculator;

namespace NUnitTestProject
{
    public class PowTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Pow_ReturnCorrectResult()
        {

            object a = 2;
            object b = 3.5;
            double expected = Math.Pow(2, 3.5);

            double result = calculator.Pow(a, b);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Pow_InvalidInputException()
        {
            object a = "invalid";
            object b = 2.5;

            Assert.Throws<NotFiniteNumberException>(() => calculator.Pow(a, b));
        }

        [Test]
        public void Pow_NullException()
        {
            
            object a = null;
            object b = null;

            Assert.Throws<NotFiniteNumberException>(() => calculator.Pow(a, b));
        }
    }
}
