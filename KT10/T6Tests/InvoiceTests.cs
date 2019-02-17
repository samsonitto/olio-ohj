using Microsoft.VisualStudio.TestTools.UnitTesting;
using T6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6.Tests
{
    [TestClass()]
    public class InvoiceTests
    {
        [TestMethod()]
        public void TotalInvoiceTest()
        {
            //Arrange
            Invoice calc = new Invoice();
            calc.products = new List<InvoiceItem>();
            double expected = calc.products.Sum(item=>item.Total);



            //Act
            double actual = new Invoice().products.Sum(item => item.Total);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}