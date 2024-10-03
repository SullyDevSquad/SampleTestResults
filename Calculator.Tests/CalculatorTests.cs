namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_WhenCalled_ReturnsSumOfArguments()
        {
            var result = Calculator.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifferenceOfArguments()
        {
            var result = Calculator.Subtract(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProductOfArguments()
        {
            var result = Calculator.Multiply(4, 3);
            Assert.That(result, Is.EqualTo(12));
        }

        // Failing tests
        [Test]
        public void Add_WhenCalled_ReturnsIncorrectSum()
        {
            var result = Calculator.Add(1, 2);
            Assert.That(result, Is.EqualTo(4)); // This test will fail
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsIncorrectDifference()
        {
            var result = Calculator.Subtract(5, 3);
            Assert.That(result, Is.EqualTo(1)); // This test will fail
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsIncorrectProduct()
        {
            var result = Calculator.Multiply(4, 3);
            Assert.That(result, Is.EqualTo(11)); // This test will fail
        }
    }
}