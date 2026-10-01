using Tyuiu.ShteltzAV.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1; 
            double x2 = 4;
            double y1 = 4;
            double y2 = 1;
            var res = ds.ElephCanMove(x1, y1, y2, x2);
            Assert.IsTrue(res);
          
        }
    }
}
