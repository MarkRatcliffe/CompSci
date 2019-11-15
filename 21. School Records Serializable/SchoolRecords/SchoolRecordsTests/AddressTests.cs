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
            Assert.AreEqual(home.GetHouseNameOrNumber(),"HSFC");
            Assert.AreEqual(home.GetStreet(), "Foley Lane");
            Assert.AreEqual(home.GetCounty(), "Herefordshire");
            Assert.AreEqual(home.GetPostCode(), "HR1 1LU");
        }

    }
}