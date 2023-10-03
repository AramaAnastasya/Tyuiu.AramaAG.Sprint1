using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint1.Task3.V19.Lib;

namespace Tyuiu.AramaAG.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 4;
            double x2 = 1;
            double y1 = 6;
            double y2 = 3;
            bool res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(true, res);
        }
    }
}
