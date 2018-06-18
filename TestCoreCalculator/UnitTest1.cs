using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreCalculator;

namespace TestCoreCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SubtractionTest()
        {
            // arrange  
            float operand1 = 11.99;
            float operand2 = 4.55;
            float expected = 7.44;
            Operation operation = new Operation(operand1, operand2);

            // act  
            operation.SubtractionOperation();

            // assert  
            double actual = operation.Result;
            Assert.AreEqual(expected, actual, 0.001, "Result is correct");
        }
    }
}
