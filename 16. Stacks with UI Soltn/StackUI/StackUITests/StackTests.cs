using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUI.Tests
{
    [TestClass()]
    public class StackTests
    {
        private Stack myStack;
        [TestMethod()]
        public void PushTest()
        {
            // lets initialise the stack
            myStack = new Stack(10);
            Assert.AreEqual(0, myStack.Depth());
            myStack.Push("Albert");
            Assert.AreEqual(1, myStack.Depth());
            Assert.AreEqual("Albert", myStack.Pop());
        }
    }
}