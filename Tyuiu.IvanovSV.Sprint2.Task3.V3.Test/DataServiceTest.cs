using Tyuiu.IvanovSV.Sprint2.Task3.V3.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiseTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataServise ds = new DataServise();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataServise ds = new DataServise();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.167;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataServise ds = new DataServise();
            double x = -2;
            double res = ds.Calculate(x);
            double wait = 0.64;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataServise ds = new DataServise();
            double x = -9;
            double res = ds.Calculate(x);
            double wait = -8.889;
            Assert.AreEqual(wait, res);
        }
    }
}