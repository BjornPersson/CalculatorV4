using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HandleButton1Test()
        {
            CalculatorHelper.HandleButton1();
            Assert.AreEqual(1, CalculatorHelper.Operand1);
        }
    }

    public class CalculatorHelper
    {
        public static int Operand1 { get; set; }

        public static void HandleButton1()
        {
            Operand1 = 1;
        }
    }
}
