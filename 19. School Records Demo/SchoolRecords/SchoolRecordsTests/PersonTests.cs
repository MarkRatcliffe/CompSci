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
    public class PersonTests
    {
        [TestMethod()]
        public void PersonTest()
        {
            // lets test the main contructor
            Address home = new Address("HSFC", "Foley Lane", "Herefordshire", "HR1 1LU");
            Person fred = new Person("Fred Bloggs",27);
            Assert.AreEqual(fred.getName(), "Fred Bloggs");
            Assert.AreEqual(fred.getAge(),27);

            // Now test my default constructor
            Person empty = new Person();
            Assert.AreEqual(empty.getName(), "");
            Assert.AreEqual(empty.getAge(), 0);

            Person bill = new Person();
            bill.setName("Bill Bloggs");
            bill.setAge(25);
            Assert.AreEqual(bill.getName(), "Bill Bloggs");
            Assert.AreEqual(bill.getAge(), 25);

            bill.setAddress(home); 
            Assert.AreEqual(bill.getAddress().getPostCode(), home.getPostCode());
 
        }
    }
}