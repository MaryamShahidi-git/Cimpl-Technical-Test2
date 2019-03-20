using CalculatorLogic;
//using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [TestClass]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.AreEqual(x, 3);
        }

        [TestClass]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.AreEqual(6, x);
        }
    }
}
