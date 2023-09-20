using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZargarovAA.Sprint1.Task1.V11.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 12.0;
            double y = 10.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}