using Tyuiu.FedorovskikhEO.Sprint1.Task0.V13.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task0.V13.Test
{
    public class DataServiceTest
    {
        [Fact]

        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.Equal(1, res);
        }
    }
}