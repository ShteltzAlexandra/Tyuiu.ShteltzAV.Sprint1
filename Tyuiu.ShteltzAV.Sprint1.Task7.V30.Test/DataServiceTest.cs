using Tyuiu.ShteltzAV.Sprint1.Task7.V30.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task7.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 5.612;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
