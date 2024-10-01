using Tyuiu.FilatovDK.Sprint1.Task4.V4.Lib;
namespace Tyuiu.FilatovDK.Sprint1.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 0.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}