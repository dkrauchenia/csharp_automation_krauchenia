namespace SeleniumTestKrauchenia
{
    [TestFixture]
    public class TriangleTests
    {
        private Triangle _triangle;

        [SetUp]
        public void Setup()
        { 
            _triangle = new Triangle();
        }

        [Test]
        public void CheckForExistenceAllSidesPositive()
        {
            double baseSide = 3;
            double firstSide = 4;
            double secondSide = 5;
           
            Assert.DoesNotThrow(() => _triangle.CheckForExistence(baseSide, firstSide, secondSide));
        }

        [TestCase(0, 4, 5)]
        [TestCase(3, 0, 5)]
        [TestCase(3, 4, 0)]
        [TestCase(-3, 4, 5)]
        [TestCase(3, -4, 5)]
        [TestCase(3, 4, -5)]
        public void CheckForExistenceNegativeOrZeroSidesThrowException(double baseSide, double firstSide, double secondSide)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => _triangle.CheckForExistence(baseSide, firstSide, secondSide));
        }

        [Test]
        public void CheckForExistenceInvalidSidesThrowException()
        {

            double baseSide = 2;
            double firstSide = 3;
            double secondSide = 7;

            Assert.Throws<ArgumentOutOfRangeException>(() => _triangle.CheckForExistence(baseSide, firstSide, secondSide));
        }
    }
}
