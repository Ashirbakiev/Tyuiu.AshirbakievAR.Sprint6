using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint6.Task6.V5.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V5.txt";
            DataService ds = new DataService();
            string res = ds.CollectTextFromFile(path);
            string wait = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";
            Assert.AreEqual(wait, res);
        }
    }
}
