using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint6.Task4.V17.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] a = {-5.04,-6,-7.85};
            CollectionAssert.AreEqual(a, ds.GetMassFunction(-1, 1));
        }
    }
}
