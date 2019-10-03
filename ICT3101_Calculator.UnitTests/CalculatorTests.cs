using ICT3101_Calculator;
using NUnit.Framework;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Subtract(20, 20);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Multiply(2, 20);
            // Assert
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(20, 2);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        /*[Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(0, 0), Throws.ArgumentException);
        }*/

        [Test]
        public void Fact_WithPositiveInputs_ResultEqualToValue()
        {
            // Act
            double result = _calculator.Factorial(5);

            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Fact_WithNegativeInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
        }

    }
}