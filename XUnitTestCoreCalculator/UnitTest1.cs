using CoreCalculator.Models;
using System;
using Xunit;

namespace XUnitTestCoreCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            double operand1 = 11.1;
            double operand2 = 7.1;
            double expected = 4;
            Operation operation = new Operation(operand1, operand2);

            // act  
            operation.SubtractionOperation();

            // assert  
            double actual = operation.Result;
            Assert.Equal(expected, operation.Result, 0);
        }
    }
}
