using NUnit.Framework;

namespace stringcalculator
{
    [TestFixture]
    public class CalculatorAddShould
    {
        [Test]
        public void ReturnZeroGivenEmptyString()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add("");

            // Assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void ReturnOneGivenNumeralOne()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add("1");

            // Assert
            Assert.AreEqual(1, result);
        }
    }
}
