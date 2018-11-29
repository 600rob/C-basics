using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreExample;

namespace StoreInvoiceTest
{
    [TestClass]
    public class InvoiceTests
    {
        Invoice invoice1 = new Invoice("part123", "jacket", 2, 35.99M);
        [TestMethod]
        public void TestGetInvoiceAmmount()

        {
            Assert.AreEqual(71.98M, invoice1.getInvoiceAmmount());
        }


        [TestMethod]

        public void TestPriceProperty()
        {

            Assert.AreEqual("part123", invoice1.PartNo);

        }


        [TestMethod]

        public void TestQuantity()
        {

            Assert.AreEqual(2, invoice1.Quantity);

        }

        [TestMethod]
        //test the set property for invalid price values. * the propery validates against negative numbers and
        //should use the default settiing of zero.
        public void TestPriceSet()
        {
            Invoice invoice2 = new Invoice("part123", "jacket", 1, -5.10M);
            Assert.AreEqual(0M, invoice2.Price);

        }

    }
}
