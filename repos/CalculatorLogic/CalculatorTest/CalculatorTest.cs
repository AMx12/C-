using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        CalculatorLogics cl = new CalculatorLogics();
        [TestMethod]
        public void Calculator_MultiplicationOperation_ReturnsValidSum()
        {
            decimal firstNumberInput = 3;
            decimal secondNumberInput = 3;
            decimal expected = 9;

            string operation = "*";

            decimal actual = cl.CalculatorOperation(firstNumberInput, secondNumberInput, operation);

            Assert.AreEqual(expected, actual, "Did not return expected sum");

        }

        [TestMethod]
        public void Calculator_AdditionOperation_ReturnsValidSum()
        {
            decimal firstNumberInput = 3;
            decimal secondNumberInput = 3;
            decimal expected = 6;

            string operation = "+";

            decimal actual = cl.CalculatorOperation(firstNumberInput, secondNumberInput, operation);

            Assert.AreEqual(expected, actual, "Did not return expected sum");

        }

        [TestMethod]
        public void Calculator_SubtractionOperation_ReturnsValidSum()
        {
            decimal firstNumberInput = 3;
            decimal secondNumberInput = 3;
            decimal expected = 0;

            string operation = "-";

            decimal actual = cl.CalculatorOperation(firstNumberInput, secondNumberInput, operation);

            Assert.AreEqual(expected, actual, "Did not return expected sum");

        }

        [TestMethod]
        public void Calculator_DivisionOperation_ReturnsValidSum()
        {
            decimal firstNumberInput = 3;
            decimal secondNumberInput = 3;
            decimal expected = 1;

            string operation = "/";

            decimal actual = cl.CalculatorOperation(firstNumberInput, secondNumberInput, operation);

            Assert.AreEqual(expected, actual, "Did not return expected sum");

        }


    }
}
