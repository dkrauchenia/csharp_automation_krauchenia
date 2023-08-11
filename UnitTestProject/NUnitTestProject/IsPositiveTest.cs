using CSharpCalculator;

namespace NUnitTestProject
{
     class IsPositiveTest
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [TestCase(5)]
        [TestCase("15")]
        public void IsPositive_ReturnTrue(object a)
        {
            bool result = calculator.isPositive(a);
            Assert.True(result);
        }

        [TestCase("invalid")]
        public void IsPositive_ReturnException(object a)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.isPositive(a));
        }
    }
}
