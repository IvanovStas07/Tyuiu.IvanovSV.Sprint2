using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IvanovSV.Sprint2.Task3.V3.Lib
{
    public class DataServise : ISprint2Task3V3
    {
        public double Calculate(double x)
        {
            double res = 0;
            if (x > 1)
            {
                res = x * Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                res = (Math.Pow(x, 4) - Math.Pow(Math.Cos(x), 5) + 3) / (Math.Pow(x, 2) - Math.Pow(Math.Sin(x), 2) + 12);
            }
            else if (-7 < x & x < 0)
            {
                res = Math.Pow(1 + (Math.Sqrt(x + 3) / Math.Pow(x, 2)), x);
            }
            else if (x < -7)
            {
                res = Math.Pow(x, 2) + 10 * x - (1 / x);
            }
            return Math.Round(res, 3);
        }
    }
}