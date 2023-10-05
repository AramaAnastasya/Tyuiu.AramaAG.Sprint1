using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AramaAG.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 59.5;
            double res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(15, res);
        }
    }
}
