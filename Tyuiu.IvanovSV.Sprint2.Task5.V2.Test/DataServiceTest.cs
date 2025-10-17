using Tyuiu.IvanovSV.Sprint2.Task5.V2.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestWinterMonth()
        {
            DataService ds = new DataService();
            string result = ds.FindMonthSeason(1);
            Assert.AreEqual("Зима", result);
        }

        [TestMethod]
        public void TestSummerMonth()
        {
            DataService ds = new DataService();
            string result = ds.FindMonthSeason(7);
            Assert.AreEqual("Лето", result);
        }

        [TestMethod]
        public void TestInvalidMonth()
        {
            DataService ds = new DataService();
            string result = ds.FindMonthSeason(13);
            Assert.AreEqual("Ошибка: нет такого месяца", result);


        }
    }
}
