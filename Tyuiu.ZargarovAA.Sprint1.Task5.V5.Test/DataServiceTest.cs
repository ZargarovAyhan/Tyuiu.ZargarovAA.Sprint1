using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 213.56;
            double wait = 5;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
