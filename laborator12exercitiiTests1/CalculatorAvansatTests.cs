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
        /*
            Console.WriteLine(CalculatorAvansat.Suma1N(5));
            Console.WriteLine(CalculatorAvansat.Suma1N(1));
            Console.WriteLine(CalculatorAvansat.Suma1N(-30));
        */
        public void Suma1NTest()
        {
            var calculator = new CalculatorAvansat();
            int n = 5;
            int expectedResult = 15;

            int result = calculator.Suma1N(n);


            Assert.AreEqual(expectedResult, result);
        }
    }
}