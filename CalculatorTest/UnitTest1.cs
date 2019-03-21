﻿using CalculatorLogic;
/* Because of this project doesn't belong a Xunit test for avoiding the error I commented this using.
   I will also create a Xunit test later. */
//using Xunit;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTest
{
    //I added this atribute whis uses in Unit Test Projects
    [TestClass]
    public class UnitTest1
    {
        /* I changed the [fact] attribute to [TestMethod] attribute in this class ,because this project is 
        a Unit Test Project and the related attribute is [TestMethod] .*/
        //[Fact]
        [TestMethod]
        public void ShouldAddTwoNumbers()
        {
            //  I added a refrence to CalculatorLogic in order to recognizing the Calculator class and its methods.
            var x = new Calculator().Sum(1, 2);
            //  I changed all methodes Equal to AreEqual in this class,because in c# have to be like this.
            //Assert.Equal(x, 3);
            Assert.AreEqual(x, 3);
        }

        [TestMethod]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.AreEqual(6, x);
        }

        [TestMethod]
        public void ShouldSubtractTwoNumbers()
        {
            var x = new Calculator().Subtract(8,5);
            Assert.AreEqual(3, x);
        }

        [TestMethod]
        public void ShouldDivideTwoNumbers()
        {
            var x = new Calculator().Divide(12, 3);
            Assert.AreEqual(4, x);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            var x = new Calculator().Divide(4, 0);
            //Should never run
            Assert.IsTrue(false);
        }
    }
}
