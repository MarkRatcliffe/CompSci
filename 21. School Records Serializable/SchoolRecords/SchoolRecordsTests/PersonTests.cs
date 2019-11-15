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
            Person fred = new Person("Fred", "Bloggs",27);
            Assert.AreEqual(fred.GetFirstName(), "Fred");
            Assert.AreEqual(fred.GetLastName(), "Bloggs");
            Assert.AreEqual(fred.GetAge(),27);

            // Now test my default constructor
            Person empty = new Person();
            Assert.AreEqual(empty.GetFirstName(), "");
            Assert.AreEqual(empty.GetAge(), 0);

            Person bill = new Person();
            bill.SetFirstName("Bill");
            bill.SetAge(25);
            Assert.AreEqual(bill.GetFirstName(), "Bill");
            Assert.AreEqual(bill.GetAge(), 25);

            bill.SetAddress(home); 
            Assert.AreEqual(bill.GetAddress().GetPostCode(), home.GetPostCode());
 
        }
    }
}