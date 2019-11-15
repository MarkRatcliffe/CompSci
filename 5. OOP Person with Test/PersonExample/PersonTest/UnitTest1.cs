using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonExample;

namespace PersonTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person p1 = new Person("Fred Smith", 45);

            // check that constructor set the name correctly, and that it matches GetName
            Assert.AreEqual("Fred Smith", p1.GetName());
            // check that constructor sets the age correctly, and that it matches GetAge
            Assert.AreEqual(45, Convert.ToInt32(p1.GetAge()));

            // check that SetName sets the name correctly, and that it matches GetName
            p1.SetName("Mary Smith");
            Assert.AreEqual("Mary Smith", p1.GetName());

            // check that SetAge sets the age correctly, and that it matches GetAge
            p1.SetAge(67);
            Assert.AreEqual(67, Convert.ToInt32(p1.GetAge()));

            //Check that toString works
            Assert.AreEqual("Mary Smith is aged 67", p1.ToString());

            // Finally check that default constructor works
            p1 = new Person();
            Assert.AreEqual("", p1.GetName());
            Assert.AreEqual(0, Convert.ToInt32(p1.GetAge()));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Address addr1 = new Address("32", "Whitecross Lane", "Hereford", "HR1 7EG");
            Assert.AreEqual("32", (addr1.getHouseNameNumber()));
            Assert.AreEqual("Whitecross Lane", (addr1.getStreet()));
            Assert.AreEqual("Hereford", (addr1.getCounty()));
            Assert.AreEqual("HR1 7EG", (addr1.getPostCode()));
            addr1.sethouseNameNumber("45");
            addr1.setStreet("Big Lane");
            addr1.setCounty("Worcester");
            addr1.setPostCode("WR1 4ER");
            Assert.AreEqual("45", (addr1.getHouseNameNumber()));
            Assert.AreEqual("Big Lane", (addr1.getStreet()));
            Assert.AreEqual("Worcester", (addr1.getCounty()));
            Assert.AreEqual("WR1 4ER", (addr1.getPostCode()));

            // And the ToString
            Assert.AreEqual("45, Big Lane, Worcester, WR1 4ER.", (addr1.ToString()));
        }
    }
}
