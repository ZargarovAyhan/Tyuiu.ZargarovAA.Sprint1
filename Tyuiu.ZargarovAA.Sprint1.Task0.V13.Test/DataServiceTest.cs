using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZargarovAA.Sprint1.V13.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);

        }
    }
}