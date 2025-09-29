using NUnit.Framework;

namespace DataStructuresToolkit.Tests
{
    [TestFixture]
    public class ComplexityTester_Tests
    {
        private ComplexityTester tester;

        [SetUp]
        public void Setup()
        {
            // Initialize before each test
            tester = new ComplexityTester();
        }

        [Test]
        public void ConstantTimeMethod_ReturnsCorrectResult()
        {
            // Act
            int result = tester.ConstantTimeMethod(5);

            // Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        public void LinearTimeMethod_SumsArrayCorrectly()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4 };

            // Act
            int result = tester.LinearTimeMethod(input);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void QuadraticTimeMethod_ComputesExpectedValue()
        {
            // Arrange
            int[] input = { 1, 2 };

            // Act
            int result = tester.QuadraticTimeMethod(input);

            // Assert
            // For [1,2]: (1*1 + 1*2 + 2*1 + 2*2) = 9
            Assert.That(result, Is.EqualTo(9));
        }
    }
}

