using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint1.Task2.V10.Lib;

namespace Tyuiu.AramaAG.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int m = 2;
            double res = ds.ConvertMetreToInchs(m);
            Assert.AreEqual(78.74, res);
        }
    }
}
