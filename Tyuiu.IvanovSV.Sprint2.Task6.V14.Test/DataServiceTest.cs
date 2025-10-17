using Tyuiu.IvanovSV.Sprint2.Task6.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void WhenJan1IsMonday_K1_IsMonday()
        {
            var ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
        }

        [TestMethod]
        public void WhenJan1IsMonday_K7_IsSunday()
        {
            var ds = new DataService();
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
        }

        [TestMethod]
        public void WhenJan1IsSunday_K2_IsMonday()
        {
            var ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(2, 7));
        }

        [TestMethod]
        public void OutOfRange_ReturnsError()
        {
            var ds = new DataService();
            Assert.AreEqual("Ошибка", ds.FindDayName(0, 1));
            Assert.AreEqual("Ошибка", ds.FindDayName(10, 8));
        }
    }
}