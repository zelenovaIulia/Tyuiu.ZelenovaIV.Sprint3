using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZelenovaIV.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;

            for (double k = startValue; k <= stopValue; k++)
            {
                double d = (value / k);
                res = res * (Math.Pow(d, 3));
            }
            return Math.Round(res, 3);
        }
    }
}