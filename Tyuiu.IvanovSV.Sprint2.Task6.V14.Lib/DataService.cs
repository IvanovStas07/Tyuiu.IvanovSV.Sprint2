using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovSV.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365 && d < 1 || d > 7)
                return "Ошибка";

            int indx = ((d - 1 + (k - 1)) % 7) + 1;

            string name = indx switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => "Ошибка"
            };

            return name;
        }
    }
}