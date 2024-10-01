using Tyuiu.FilatovDK.Sprint1.Task6.V18.Lib;
namespace Tyuiu.FilatovDK.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string boolTest = "123";
            DataService ds = new DataService();
            var res = ds.CheckNumber(boolTest);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}