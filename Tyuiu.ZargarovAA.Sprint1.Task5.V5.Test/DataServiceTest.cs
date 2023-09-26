using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 153.9696789;
            DataService ds = new DataService();
            double res = (int)((a % 1) * 10);
            double wait = 9;
            Assert.AreEqual(wait, res);
        }
    }
}
