using Tyuiu.ShteltzAV.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ShteltzAV.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "шалаш";
            bool res = ds.CheckPalindrome( strTest );
            bool wait = true;
            Assert.AreEqual(wait, res);

        }
    }
}
