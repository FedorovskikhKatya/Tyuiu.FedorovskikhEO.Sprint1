using Tyuiu.FedorovskikhEO.Sprint1.Task4.V12.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0;
            var res = ds.Calculate(x, y);  
            Assert.AreEqual(wait, res);
        }
    }
}
