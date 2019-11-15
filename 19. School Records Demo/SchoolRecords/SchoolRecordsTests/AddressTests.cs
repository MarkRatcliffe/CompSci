using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords.Tests
{
    [TestClass()]
    public class AddressTests
    {
        [TestMethod()]
        public void AddressTest()
        {
            Address home = new Address("HSFC", "Foley Lane", "Herefordshire", "HR1 1LU");
            Assert.AreEqual(home.getHouseNameNumber(),"HSFC");
            Assert.AreEqual(home.getStreet(), "Foley Lane");
            Assert.AreEqual(home.getCounty(), "Herefordshire");
            Assert.AreEqual(home.getPostCode(), "HR1 1LU");
        }

    }
}