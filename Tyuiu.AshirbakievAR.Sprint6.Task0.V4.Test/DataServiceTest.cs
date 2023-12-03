using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint6.Task0.V4.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(68.3, ds.Calculate(3));
        }
    }
}
