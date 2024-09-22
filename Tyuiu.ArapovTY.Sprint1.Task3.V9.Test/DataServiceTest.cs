using Tyuiu.ArapovTY.Sprint1.Task3.V9.Lib;
namespace Tyuiu.ArapovTY.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 120;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(2, res);
        }
    }
}