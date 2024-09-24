using Tyuiu.ArapovTY.Sprint1.Task6.V3.Lib;
namespace Tyuiu.ArapovTY.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string word = "солнце море жара";
            string res = ds.LastLetterWord(word);
            string value = "ееа";
            Assert.AreEqual(value, res);
        }
    }
}