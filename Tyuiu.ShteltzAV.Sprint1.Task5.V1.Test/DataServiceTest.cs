using Tyuiu.ShteltzAV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1;
            double y1 = 2;
            double x2 = 4;
            double y2 = 6;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            int wait = 5;

            Assert.AreEqual(wait, result);


        }
    }
}
