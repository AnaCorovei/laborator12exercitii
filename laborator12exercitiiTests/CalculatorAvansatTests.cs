using Microsoft.VisualStudio.TestTools.UnitTesting;
using laborator12exercitii;
using System;
using System.Collections.Generic;
using System.Text;

namespace laborator12exercitii.Tests
{
    [TestClass()]
    public class CalculatorAvansatTests
    {
        [TestMethod()]
        public void Suma1NTest()
        {
            var calculator = new CalculatorAvansat();
            int n = 5;
            long expectedResult = 15;

            long result = calculator.Suma1N(n);


            Assert.AreEqual(expectedResult, result);
        }
    }
}