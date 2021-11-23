using System;
using Xunit;

namespace StringCalculatorKataTDD
{
    public class StringCalculator_Add
    {
        [Fact]
        public void ReturnsZeroGivenEmptyString()
        {
            var calculator = new StringCalculator();
            var result = calculator.Add("");
            Assert.Equal(0, result);
        }
    }
}
