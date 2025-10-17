using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.IvanovSV.Sprint2.Task1.V28.Lib
{
    public class DataService : ISprint2Task1V28
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];// a=247,b=654,c,d=671
            res[0] = (a < b) | (c > d);
            res[1] = (a > b) & (c == d);
            res[2] = (a + 2 < b) || (c != d);
            res[3] = (a - 100 > b) && (c + 1 < d);
            res[4] = !res[1];
            res[5] = (a < b) ^ (c == d);
            return res;
        }
    }
}