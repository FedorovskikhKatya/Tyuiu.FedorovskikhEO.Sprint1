using Tyuiu.FedorovskikhEO.Sprint1.Task2.V1.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(6.215, res);
        }
    }
}
 