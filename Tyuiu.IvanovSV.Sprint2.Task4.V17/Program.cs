using Tyuiu.IvanovSV.Sprint2.Task4.V17.Lib;

namespace Tyuiu.IvanovSV.Sprint2.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Иванов С. В. | ИСТНб-25-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Задание #4                                                                      *");
            Console.WriteLine("* Вариант #14                                                                     *");
            Console.WriteLine("* Выполнил: Иванов С. В. | ИСТНб-25-1                                             *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием       *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значение X, Y с клавиатуры        *");
            Console.WriteLine("* если x-22 > y^(0.5), то z=(6+(2/x^2))^2, иначе z=y+(12/(x^2))                   *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Введите значение X :  ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y :  ");
            double y = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x, y);
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Значение функции: " + res);
        }
    }
}