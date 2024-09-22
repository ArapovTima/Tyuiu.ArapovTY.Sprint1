using Tyuiu.ArapovTY.Sprint1.Task4.V20.Lib;
namespace Tyuiu.ArapovTY.Sprint1.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double wait = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}