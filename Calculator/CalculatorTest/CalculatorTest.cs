using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void HandleButton1Test()
        {
            CalculatorHelper calculatorhelper = new CalculatorHelper();
            calculatorhelper.HandleButton1();
            Assert.AreEqual(1, CalculatorHelper.Operand1);
        }

        [TestMethod]
        public void Display1Test()
        {
            CalculatorHelper calculatorhelper = new CalculatorHelper();
            calculatorhelper.HandleButton1();
            Assert.AreEqual("1", calculatorhelper.DisplayText);
        }
    }
}
