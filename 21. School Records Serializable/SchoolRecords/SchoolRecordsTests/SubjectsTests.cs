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
    public class SubjectsTests
    {
        [TestMethod()]
        public void SubjectsTest()
        {
            Subjects mySubs = new Subjects(6);
            Subject s1 = new SchoolRecords.Subject("Geography", "A Level");
            mySubs.AddSubject(s1);
            Assert.AreEqual(1, mySubs.GetCurrentSize()); ;
            Subject s2 = new SchoolRecords.Subject("French", "A Level");
            mySubs.AddSubject(s2);
            Assert.AreEqual("French", mySubs.GetSubject(1).GetName());
            Assert.AreEqual(mySubs.GetCurrentSize(), 2);
            Assert.AreEqual(0, mySubs.RemoveSubject("Geography", "A Level"));
            Assert.AreEqual(-1, mySubs.RemoveSubject("Geography", "A Level"));
            Assert.AreEqual(mySubs.GetCurrentSize(), 1);
            Assert.AreEqual("French", mySubs.GetSubject(0).GetName());
            Assert.AreEqual(0, mySubs.RemoveSubject("French", "A Level"));
            Assert.AreEqual(mySubs.GetCurrentSize(), 0);
            Subject s3 = new SchoolRecords.Subject("Maths", "BTEC");
            mySubs.AddSubject(s3);
            Subject s4 = new SchoolRecords.Subject("Comp Sci", "A Level");
            mySubs.AddSubject(s4);
            Assert.AreEqual(mySubs.GetCurrentSize(), 2);
            mySubs.AddSubject(s4);
            mySubs.AddSubject(s4);
            Assert.AreEqual(mySubs.GetCurrentSize(), 4);
        }

    }
}