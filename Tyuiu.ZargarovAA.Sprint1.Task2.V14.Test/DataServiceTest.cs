using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint1.Task2.V14.Lib;
namespace Tyuiu.ZargarovAA.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 280;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(7, res);

        }
    }
}
