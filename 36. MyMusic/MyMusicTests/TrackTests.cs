using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMusic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Tests
{
    [TestClass()]
    public class TrackTests
    {
        [TestMethod()]
        public void TrackTest()
        {
            Track theTrack = new Track("Dancing Queen", "Abba");
            Assert.AreEqual("Dancing Queen", theTrack.GetTitle());
            Assert.AreEqual("Abba", theTrack.GetArtist());
        }
    }
}