using Tyuiu.FedorovskikhEO.Sprint1.Task3.V15.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 60;
            double y = 80;
            double s = 100;
            double t = 2;
            double wait = 380;
            var res = ds.DistanceOverTime(x, y,s,t);
            Assert.AreEqual(wait, res);
        }
    }
}
