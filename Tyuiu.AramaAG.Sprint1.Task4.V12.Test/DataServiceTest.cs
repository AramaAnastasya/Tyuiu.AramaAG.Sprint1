using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint1.Task4.V12.Lib;

namespace Tyuiu.AramaAG.Sprint1.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.522, res);
        }
    }
}
