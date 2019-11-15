using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample.Tests
{
    [TestClass()]
    public class QueueTests
    {
        private Queue myQueue;    // let's define the Queue
        [TestMethod()]

        public void AddTest()
        {
            myQueue = new Queue(5);
            Assert.AreEqual(0, myQueue.Length());
            myQueue.Add("Arthur");
            Assert.AreEqual(1, myQueue.Length());
            myQueue.Add("William");
            Assert.AreEqual(2, myQueue.Length());
        }

        [TestMethod()]
        public void RemoveTest()
        {
            myQueue = new Queue(5);
            Assert.AreEqual(null, myQueue.Remove());
            Assert.AreEqual(0, myQueue.Length());
            myQueue.Add("William");
            Assert.AreEqual(1, myQueue.Length());
            Assert.AreEqual("William", myQueue.Remove());
        }
    }
}