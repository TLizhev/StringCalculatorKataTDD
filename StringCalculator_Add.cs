using System;
using Xunit;

namespace StringCalculatorKataTDD
{
    public class StringCalculator_Add
    {
        private StringCalculator calculator = new StringCalculator();
        [Fact]
        public void ReturnsZeroGivenEmptyString()
        {
            var result = calculator.Add("");
            Assert.Equal(0, result);
        }        
        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnsNumberGivenStringWithOneNumber(string numbers,int expectedResult)
        {
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData("1,2",3)]
        [InlineData("2,3",5)]
        public void ReturnsSumGivenStringWithTwoCommaSeparatedNumbers(string numbers,int expectedResult)
        {
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        } 
        
        [Theory]
        [InlineData("1,2,3",6)]
        [InlineData("2,3,4",9)]
        public void ReturnsSumGivenStringWithMultipleCommaSeparatedNumbers(string numbers,int expectedResult)
        {
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        } 
        [Theory]
        [InlineData("1\n2,3",6)]
        [InlineData("1\n2\n3",6)]
        [InlineData("1,2\n3",6)]
        public void ReturnsSumGivenStringWithMultipleCommaOrNewlineSeparatedNumbers(string numbers,int expectedResult)
        {
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        } 
        
        [Theory]
        [InlineData("//;\n1;2;3",6)]

        public void ReturnsSumGivenStringWithCustomDelimiter(string numbers,int expectedResult)
        {
            var result = calculator.Add(numbers);
            Assert.Equal(expectedResult, result);
        }
    }
}
