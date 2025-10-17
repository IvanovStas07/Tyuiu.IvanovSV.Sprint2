using Tyuiu.IvanovSV.Sprint2.Task0.V19.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task0.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт 1 | Выполнил: Иванов С В | ИСТНб-25-1";
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #19                                                            *");
            Console.WriteLine("* Выполнил: Иванов С В | ИСТНб-25-1                                       *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться) и арифметических выражений,  *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, True, True, True, True, True), при x = 105, y = 177                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine(new string('*', 75));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine(new string('*', 75));
            int x = 105;
            int y = 177;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("РЕЗУЛЬТАТ");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
