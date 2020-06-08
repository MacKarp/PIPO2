using System;
using lab6_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab6_1_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Oblicz_0()
        {
            Silnia silnia0 = new Silnia();
            silnia0.n = 0;
            Assert.AreEqual(silnia0.oblicz(), 1);
        }
        [TestMethod]
        public void Test_Oblicz_1()
        {
            Silnia silnia1 = new Silnia();
            silnia1.n = 1;
            Assert.AreEqual(silnia1.oblicz(), 1);
        }
        [TestMethod]
        public void Test_Oblicz_5()
        {
            Silnia silnia5 = new Silnia();
            silnia5.n = 5;
            Assert.AreEqual(silnia5.oblicz(), 120);
        }
    }
}
