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

        /*
           Console.WriteLine(CalculatorAvansat.Suma1N(5));
           Console.WriteLine(CalculatorAvansat.Suma1N(1));
           Console.WriteLine(CalculatorAvansat.Suma1N(-30));
       */
        [TestMethod()]
        public void Suma1NTest()
        {
            //Arrange
            var calculator = new CalculatorAvansat();
            int n = 5;
            int expectedResult = 15;


            //Act
            int result = calculator.Suma1N(n);

            //Assert
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod()]
        public void SumaTest()
        {

        }

        [TestMethod()]
        public void EsteParTest3()
        {
            int n = 3;
            var calculator = new CalculatorAvansat();

            var result = calculator.EstePar(n);

            Assert.IsFalse(result);

        }


        [TestMethod()]
        public void EsteParTest4()
        {
            int n = 4;
            var calculator = new CalculatorAvansat();

            var result = calculator.EstePar(n);

            Assert.IsTrue(result);

        }




        [TestMethod()]

        [DataRow(10, 3628800)]
        [DataRow(1, 1)]
        [DataRow(-10, 0)]
        [DataRow(0, 1)]
        public void FactorialTest(int n, int expectedResult)
        {

            var calculator = new CalculatorAvansat();
            var result = calculator.Factorial(n);
            Assert.AreEqual(expectedResult, result);
        }




        //[TestMethod()]
        //public void FactorialTest10()
        //{
        //    int n = 10;
        //    var calculator = new CalculatorAvansat();

        //    var result = calculator.Factorial(n);
        //    Assert.AreEqual(3628800, result);
        //}

        //[TestMethod()]
        //public void FactorialTest1()
        //{
        //    int n = 1;
        //    var calculator = new CalculatorAvansat();

        //    var result = calculator.Factorial(n);
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod()]
        //public void FactorialTest0()
        //{
        //    int n = 0;
        //    var calculator = new CalculatorAvansat();

        //    var result = calculator.Factorial(n);
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod()]
        //public void FactorialNgativ()
        //{
        //    int n = -50;
        //    var calculator = new CalculatorAvansat();

        //    var result = calculator.Factorial(n);
        //    Assert.AreEqual(0, result);
        //}
    }
}
