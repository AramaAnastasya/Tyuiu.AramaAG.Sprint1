using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AramaAG.Sprint1.Task6.V1.Lib;

namespace Tyuiu.AramaAG.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "1";
            string res = ds.SymbolCode(value);
            Assert.AreEqual("49", res);
        }
    }
}
