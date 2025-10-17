using Tyuiu.IvanovSV.Sprint2.Task5.V2.Lib;
namespace Tyuiu.IvanovSV.Sprint2.Task5.V2
{
    internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Иванов С. В. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #2                                                              *");
        Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* По номеру месяца определить пору года: Зима, Весна, Лето, Осень.        *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Введите номер месяца (1–12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();
        string season = ds.FindMonthSeason(month);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Пора года: " + season);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
}