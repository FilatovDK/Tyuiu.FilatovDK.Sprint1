using System;
using Tyuiu.FilatovDK.Sprint1.Task1.V5.Lib;
namespace Tyuiu.FilatovDK.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServicTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(7, res);
        }
    }
}