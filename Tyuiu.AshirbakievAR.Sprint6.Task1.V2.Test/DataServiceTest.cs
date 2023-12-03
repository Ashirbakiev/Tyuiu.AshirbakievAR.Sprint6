using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint6.Task1.V2.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = { -15.60, -12.35, -10.72, -8.88, -2.16, 3.25, 6.64, 10.30, 16.17, 28.10, 38.41};
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, 5));
        }
    }
}
