using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZelenovaIV.Sprint3.Task6.V27.Lib
{
    public class DataService : ISprint3Task6V27
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d < 11; d++)
                {
                    if (x % d == 0)
                    {
                        res = res + x;
                    }
                }
            }
            return res;
        }
    }
}