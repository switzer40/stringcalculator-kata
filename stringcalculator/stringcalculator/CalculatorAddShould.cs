using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
