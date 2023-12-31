﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZargarovAA.Sprint1.Task4.V4.Lib;

namespace Tyuiu.ZargarovAA.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 3;
            double wait = 2.167;
                var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
