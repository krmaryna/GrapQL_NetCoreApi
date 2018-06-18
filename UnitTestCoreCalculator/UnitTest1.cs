using CoreCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCoreCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSubtraction()
        {
            double operand1 = 11.5;
            double operand2 = 7.1;
            double expected = 4;
            Operation operation = new Operation(operand1, operand2);

            // act  
            operation.SubtractionOperation();

            // assert  
            double actual = operation.Result;
            Assert.AreEqual(expected, operation.Result, 0.001, "Result is not correct");

        }
    }
}
