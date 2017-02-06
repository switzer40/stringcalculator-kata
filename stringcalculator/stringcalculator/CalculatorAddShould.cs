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
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void ReturnIntegerGivenSingleInteger(string input, int expectedResult)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Add(input);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
