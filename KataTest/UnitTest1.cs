using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTest
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void TestShouldReturn_kata1()
        {
            NextBiggerNumberTest(12, 21);
        }

        [TestMethod]
        public void TestShouldReturn_kata2()
        {
            NextBiggerNumberTest(513, 531);
        }

        [TestMethod]
        public void TestShouldReturn_kata3()
        {
            NextBiggerNumberTest(2017, 2071);
        }

        [TestMethod]
        public void TestShouldReturn_kata4()
        {
            NextBiggerNumberTest(414, 441);
        }

        [TestMethod]
        public void TestShouldReturn_kata5()
        {
            NextBiggerNumberTest(144, 414);
        }



        public void NextBiggerNumberTest(long input, long expect)
        {
            var nextBiggerNumberClass = new NextBiggerNumberClass();
            var actual = nextBiggerNumberClass.NextBiggerNumber(input);
            Assert.AreEqual(expect, actual);
        }
    }
}
