using Tyuiu.FilatovDK.Sprint1.Task2.V8.Lib;
namespace Tyuiu.FilatovDK.Sprint1.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            var res = ds.CalculatePerimetr(a, b);
            Assert.AreEqual(10, res);
        }
    }
}