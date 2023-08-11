using CSharpCalculator;

namespace NUnitTestProject
{
    [TestFixture]
    public class AdditionTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(3, 4, 7)]
        [TestCase(-5, -10, -15)]
        public void Add_ReturnsCorrectResult(double a, double b, double expected)
        {
            double result = calculator.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        
        [TestCase("abc", "xyz")]
        public void Add_ReturnException(object a, object b)
        {
            Assert.Throws<InvalidCastException>(() => calculator.Add( a, b));
        }
    }
}