using Tyuiu.ArapovTY.Sprint1.Task1.V24.Lib;
namespace Tyuiu.ArapovTY.Sprint1.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = -2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1, res);
        }
    }
}