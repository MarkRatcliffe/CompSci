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
    public class MusicCollectionTests
    {
        [TestMethod()]
        public void MusicCollectionTest()
        {
            MusicCollection musicTest = new MusicCollection(100, "Abba");
            if (!musicTest.ReadFromFile())    // should use the standard in resources
                Assert.Fail();
            Track temp = musicTest.search("Waterloo", "Abba");
            Assert.AreEqual(temp.GetTitle(), "Waterloo");
            Assert.AreEqual(temp.GetArtist(), "Abba");
            temp = new Track("Chiquitita", "Abba");
            musicTest.addTrack(temp);
            // try writing to a new temporary file
            if (!musicTest.WriteToFile("new_text_file"))
                Assert.Fail();

            // now try reading back from the new file
            if (!musicTest.ReadFromFile("new_text_file"))    // should use the standard in resources
                Assert.Fail();

            // test that new entry still exists
            temp = musicTest.search("Chiquitita", "Abba");
            Assert.AreEqual(temp.GetTitle(), "Chiquitita");
            Assert.AreEqual(temp.GetArtist(), "Abba");

        }

        [TestMethod()]
        public void addTrackTest()
        {
            MusicCollection musicTest = new MusicCollection(1, "Abba");
            Assert.AreEqual(0, musicTest.Size());
            Track temp = new Track("Knowing me, Knowing you", "Abba");
            musicTest.addTrack(temp);
            Assert.AreEqual(1, musicTest.Size());
            Assert.AreEqual("Knowing me, Knowing you", musicTest.GetTrackByPosition(0).GetTitle());
            Assert.AreEqual("Abba", musicTest.GetTrackByPosition(0).GetArtist());
        }
    }
}