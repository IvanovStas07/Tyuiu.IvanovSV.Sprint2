using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovSV.Sprint2.Task4.V17.Lib
{
    public class DataService : ISprint2Task4V17
    {
        public double Calculate(double x, double y)
        {
            double u = Math.Sqrt(y);
            double z = x - 22 > u ? Math.Pow(6 + (2 / (x * x)), 2) : y + (12 / (x * x));
            return Math.Round(z, 3);
        }
    }
}