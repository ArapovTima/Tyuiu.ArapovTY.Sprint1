using Tyuiu.ArapovTY.Sprint1.Task7.V8.Lib;
namespace Tyuiu.ArapovTY.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 3;
            double wait = 14.495;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}