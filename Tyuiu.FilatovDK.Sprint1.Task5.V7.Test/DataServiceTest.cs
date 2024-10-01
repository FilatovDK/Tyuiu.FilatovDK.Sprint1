using Tyuiu.FilatovDK.Sprint1.Task5.V7.Lib;
namespace Tyuiu.FilatovDK.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double f = 260;
            double wait = 8;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}