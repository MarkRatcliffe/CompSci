using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreakoutGameDemo;
using System.Drawing;

namespace NewBreakOutTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetBlnIsVisible()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            Assert.AreEqual(true, brick.GetBlnIsVisible());
        }
        [TestMethod]
        public void TestPosition()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            Rectangle rec = brick.GetRecPosition();
            Rectangle testRec = new Rectangle(41, 100, 80, 20);
            Assert.AreEqual(rec, testRec);
        }
        [TestMethod]
        public void TestBrushColour()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            Assert.AreEqual(System.Drawing.Brushes.Red, brick.GetDrawingBrushColour());
            brick.SetDrawingBrushColour(System.Drawing.Brushes.Yellow);
            Assert.AreEqual(System.Drawing.Brushes.Yellow, brick.GetDrawingBrushColour());
        }
        [TestMethod]
        public void TestVisibility()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            brick.MakeInvisible();
            Assert.AreEqual(false, brick.GetBlnIsVisible());
            brick.MakeVisible();
            Assert.AreEqual(true, brick.GetBlnIsVisible());
        }
        [TestMethod]
        public void TestCheckForIntersect()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            GameObject brickOther = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            Assert.AreEqual(true, brick.CheckForIntersect(brickOther.GetRecPosition()));
        }
        [TestMethod]
        public void TestFailedCheckForIntersect()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            GameObject brickOther = new GameObject(0, 0, 80, 20, true, Brushes.Red);
            Assert.AreEqual(false, brick.CheckForIntersect(brickOther.GetRecPosition()));
        }
        [TestMethod]
        public void TestBorderlineCheckForIntersect()
        {
            GameObject brick = new GameObject(41, 100, 80, 20, true, Brushes.Red);
            GameObject brickOther = new GameObject(120, 119, 80, 20, true, Brushes.Red);
            Assert.AreEqual(true, brick.CheckForIntersect(brickOther.GetRecPosition()));
        }
    }


    [TestClass]
    public class MoveableGameObjectTests
    {
        [TestMethod]
        public void TestGetBlnIsGlued()
        {
            MoveableGameObject ball = new MoveableGameObject(298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, System.Drawing.Brushes.Yellow);
            Assert.AreEqual(true, ball.GetBlnIsGlued());
        }
        [TestMethod]
        public void TestPosition()
        {
            MoveableGameObject ball = new MoveableGameObject(298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, System.Drawing.Brushes.Yellow);

            Rectangle rec = ball.GetRecPosition();
            Rectangle testRec = new Rectangle(298,414,20,20);
            Assert.AreEqual(rec, testRec);
        }
        [TestMethod]
        public void TestGlueing()
        {
            MoveableGameObject ball = new MoveableGameObject(298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, System.Drawing.Brushes.Yellow);
            ball.UnGlue();
            Assert.AreEqual(false, ball.GetBlnIsGlued());
            ball.Glue();
            Assert.AreEqual(true, ball.GetBlnIsGlued());
        }
        [TestMethod]
        public void TestChangePosition()
        {
            MoveableGameObject ball = new MoveableGameObject(298, 414, 20, 20, true, 20, 8.161641f, 8.161641f, true, System.Drawing.Brushes.Yellow);
            Rectangle testRecOne = new Rectangle(100, 100, 20, 20);
            ball.ChangePosition(100, 100);
            Assert.AreEqual(ball.GetRecPosition(), testRecOne);
            ball.ChangePosition(200);
            Rectangle testRecTwo = new Rectangle(200, 100, 20, 20);
            Assert.AreEqual(ball.GetRecPosition(), testRecTwo);
        }
        
    }

}
