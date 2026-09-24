using System.Globalization;
using Tyuiu.FedorovskikhEO.Sprint1.Task6.V5.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint1.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "казак шалаш привет";
            DataService ds= new DataService();
            string res = ds.CheckSymmetricalWords(strTest);
            string wait = "казак шалаш";
            Assert.AreEqual(wait, res);
        }
    }
} 
