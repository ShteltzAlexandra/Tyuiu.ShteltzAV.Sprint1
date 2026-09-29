using Tyuiu.ShteltzAV.Sprint1.Task1.V23.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task1.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService(); 
            double a = 1.0;
            double x = 2.0;
            var res = ds.Calculate(a, x);
            Assert.AreEqual(3.14, res);
        }
    }
}
