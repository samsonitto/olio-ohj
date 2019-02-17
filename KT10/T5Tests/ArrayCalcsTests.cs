using Microsoft.VisualStudio.TestTools.UnitTesting;
using T5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //Arrange
            //ArrayCalcs calc = new ArrayCalcs();
            double[] arr = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = arr.Sum();

            //Act
            double actual = ArrayCalcs.Sum(arr);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AvgTest()
        {
            double[] arr = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = Math.Round(arr.Average(), 2);

            //Act
            double actual = ArrayCalcs.Avg(arr);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] arr = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = arr.Max();

            //Act
            double actual = ArrayCalcs.Max(arr);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            double[] arr = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            double expected = arr.Min();

            //Act
            double actual = ArrayCalcs.Min(arr);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}