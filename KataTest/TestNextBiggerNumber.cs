using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTest
{
    [TestClass]
    public class TestNextBiggerNumber
    {
        [TestMethod]
        public void TestShouldReturn_Negative1()
        {
            NextBiggerNumberTest(222,-1);
        }

        [TestMethod]
        public void TestShouldReturn2_Negative1()
        {
            NextBiggerNumberTest(543, -1);
        }

        [TestMethod]
        public void TestShouldReturn_398()
        {
            NextBiggerNumberTest(389, 398);
        }

        [TestMethod]
        public void TestShouldReturn_4139()
        {
            NextBiggerNumberTest(3941, 4139);
        }

        public void NextBiggerNumberTest(long input, long expect)
        {
            var nextBiggerNumberClass = new NextBiggerNumberClass();
            var actual = nextBiggerNumberClass.NextBiggerNumber(input);
            Assert.AreEqual(expect, actual);
        }
    }
}
