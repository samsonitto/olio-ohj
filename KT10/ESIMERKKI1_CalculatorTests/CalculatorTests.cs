using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESIMERKKI1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIMERKKI1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 5;
            int expected = 10;

            //Act
            int actual = calc.Add(number1, number2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int number1 = 5;
            int number2 = 5;
            int expected = 25;

            int actual = calc.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }
    }
}