using Tyuiu.ShteltzAV.Sprint1.Task2.V11.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int h = 12;
            int m = 45;
            var res = ds.ConvertHoursMinutesToSeconds(h, m);
            Assert.AreEqual(45900, res);

        }
    }
}
