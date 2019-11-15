using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakoutGameDemo;
using System.Drawing;

// Need to add this one
using System.Windows.Forms;   // I had to add this to the Referenves in Solution Explorer too

namespace NewBreakOutTests
{
    [TestClass]
    public class UnitTest1
    {
        public Form testForm = new Form();
        [TestMethod]
        public void TestIsVisible()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            Assert.AreEqual(true, brick.IsVisible());
        }
        [TestMethod]
        public void TestPosition()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            Rectangle rec = brick.GetPosition();
            Rectangle testRec = new Rectangle(41, 100, 80, 20);
            Assert.AreEqual(rec, testRec);
        }
        [TestMethod]
        public void TestColour()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            Assert.AreEqual(Color.Red, brick.GetColour());
            brick.SetColour(Color.Yellow);
            Assert.AreEqual(Color.Yellow, brick.GetColour());
        }
        [TestMethod]
        public void TestVisibility()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            brick.SetVisibility(false);
            Assert.AreEqual(false, brick.IsVisible());
            brick.SetVisibility(true);
            Assert.AreEqual(true, brick.IsVisible());
        }
        [TestMethod]
        public void TestCheckForIntersect()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            GameObject brickOther = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            Assert.AreEqual(true, brick.CheckForIntersect(brickOther));
        }
        [TestMethod]
        public void TestFailedCheckForIntersect()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            GameObject brickOther = new GameObject(testForm, 0, 0, 80, 20, true, Color.Red);
            Assert.AreEqual(false, brick.CheckForIntersect(brickOther));
        }
        [TestMethod]
        public void TestBorderlineCheckForIntersect()
        {
            GameObject brick = new GameObject(testForm, 41, 100, 80, 20, true, Color.Red);
            GameObject brickOther = new GameObject(testForm, 120, 119, 80, 20, true, Color.Red);
            Assert.AreEqual(true, brick.CheckForIntersect(brickOther));
        }
    }


    [TestClass]
    public class MoveableGameObjectTests
    {
        public Form testForm = new Form();
        [TestMethod]
        public void TestIsGlued()
        {
            MoveableGameObject ball = new MoveableGameObject(testForm, 298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, Color.Yellow);
            Assert.AreEqual(true, ball.IsGlued());
        }
        [TestMethod]
        public void TestPosition()
        {
            MoveableGameObject ball = new MoveableGameObject(testForm, 298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, Color.Yellow);

            Rectangle rec = ball.GetPosition();
            Rectangle testRec = new Rectangle(298,414,20,20);
            Assert.AreEqual(rec, testRec);
        }
        [TestMethod]
        public void TestGlueing()
        {
            MoveableGameObject ball = new MoveableGameObject(testForm, 298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, Color.Yellow);
            ball.UnGlue();
            Assert.AreEqual(false, ball.IsGlued());
            ball.Glue();
            Assert.AreEqual(true, ball.IsGlued());
        }
        [TestMethod]
        public void TestChangePosition()
        {
            MoveableGameObject ball = new MoveableGameObject(testForm, 298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, Color.Yellow);
            Rectangle testRecOne = new Rectangle(100, 100, 20, 20);
            ball.ChangePosition(100, 100);
            Assert.AreEqual(ball.GetPosition(), testRecOne);
            ball.ChangePosition(200);
            Rectangle testRecTwo = new Rectangle(200, 100, 20, 20);
            Assert.AreEqual(ball.GetPosition(), testRecTwo);
        }
        
    }

}
