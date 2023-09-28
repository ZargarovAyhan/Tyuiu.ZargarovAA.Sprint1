using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint1.Task6.V5.Lib;
namespace Tyuiu.ZargarovAA.Sprint1.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "мышь, казак шалаш убу";
            DataService ds = new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак шалаш убу";
            Assert.AreEqual(wait, res);
        }
    }
}
