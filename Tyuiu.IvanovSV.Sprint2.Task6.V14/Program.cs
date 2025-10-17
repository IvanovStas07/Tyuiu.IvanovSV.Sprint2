using Tyuiu.IvanovSV.Sprint2.Task6.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Иванов С. В. | ИСТНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано k (1..365) и d (1..7) — день недели 1 января. Определить, какой    *");
            Console.WriteLine("* день недели у k-го дня (1=Пн ... 7=Вс).                                 *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите k (1..365): ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите d для 1 января (1=Пн ... 7=Вс): ");
            int d = Convert.ToInt32(Console.ReadLine());

            var ds = new DataService();
            string result = ds.FindDayName(k, d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("День недели: " + result);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}