using Tyuiu.ArapovTY.Sprint1.Task5.V3.Lib;
namespace Tyuiu.ArapovTY.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            var res = ds.Calculate(k);
            int h = (k / 100) % 10; 
            Assert.AreEqual(h, res);
        }
    }
}