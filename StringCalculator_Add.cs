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
        [Theory]
        [InlineData("1",1)]
        public void ReturnsOneGivenStringWithOne(string numbers,int expectedResult)
        {
            var calculator = new StringCalculator();
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }
    }
}
