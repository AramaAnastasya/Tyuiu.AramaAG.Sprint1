using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint1.Task7.V14.Lib;

namespace Tyuiu.AramaAG.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 0.5;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(2.468, res);
        }
    }
}
