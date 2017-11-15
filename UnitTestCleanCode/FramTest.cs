using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CleanCodeStudy;

namespace UnitTestCleanCode
{
    [TestClass]
    public class FramTest
    {
        [TestMethod]
        public void TestScoreNoThrows()
        {
            Frame f = new Frame();
            Assert.AreEqual(0, f.Score);
        }

        [TestMethod]
        public void TestAddOneThrow()
        {
            Frame f = new Frame();
            f.Add(5);
            Assert.AreEqual(5, f.Score);
        }
    }
}
