using Tyuiu.FilatovDK.Sprint1.Task7.V3.Lib;
namespace Tyuiu.FilatovDK.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double wait = 2.568;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}