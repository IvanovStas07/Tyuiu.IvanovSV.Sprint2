using Tyuiu.IvanovSV.Sprint2.Task4.V17.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 25;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 36.038;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 25;
            double y = 100;
            double res = ds.Calculate(x, y);
            double wait = 100.019;
            Assert.AreEqual(wait, res);
        }
    }
}
