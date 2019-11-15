using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sockets.Tests
{
    [TestClass()]
    public class QueueTests
    {
        private Queue myQueue;
        [TestMethod()]
        public void EnQueueTest()
        {
            myQueue = new Queue(5);
            Assert.AreEqual(0, myQueue.Length());
            myQueue.EnQueue("Arthur");
            Assert.AreEqual(1, myQueue.Length());
            myQueue.EnQueue("William");
            Assert.AreEqual(2, myQueue.Length());
        }

        [TestMethod()]
        public void DequeueTest()
        {
            myQueue = new Queue(5);
            Assert.AreEqual(null, myQueue.DeQueue());
            Assert.AreEqual(0, myQueue.Length());
            myQueue.EnQueue("William");
            Assert.AreEqual(1, myQueue.Length());
            Assert.AreEqual("William", myQueue.DeQueue());
        }

        [TestMethod()]
        public void TestIsEmpty()
        {
            myQueue = new Queue(3);
            Assert.AreEqual(true, myQueue.IsEmpty());
            myQueue.EnQueue("Chris");
            Assert.AreEqual(false, myQueue.IsEmpty());
            myQueue.DeQueue();
            Assert.AreEqual(true, myQueue.IsEmpty());
        }


    }
}