using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint1.Task3.V14.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 132;
            var res = ds.ReverseNumber(x);
            Assert.AreEqual(231, res);
        }
    }
}
