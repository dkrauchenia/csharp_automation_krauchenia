using CSharpCalculator;
using System;
namespace NUnitTestProject
{
    [TestFixture]
    public class SubtractionTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        
        [TestCase(6, 9, -3)]
        [TestCase(-6, -9, 3)]
        public void Sub_ReturnCorrectResult(double a, double b, double expected)
        {
            double result = calculator.Sub(a, b);
            Assert.AreEqual(expected, result);
        }

        [TestCase("a","b")]
        public void Sub_ReturnException(object a, object b) 
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sub(a, b));
        }

    }


}
