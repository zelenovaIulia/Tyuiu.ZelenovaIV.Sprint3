using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZelenovaIV.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double ps = 1;
            double fa = 1.8;

            do
            {
                ps *= Math.Pow(2, startValue) / (startValue + 1);
                startValue++;
            } while (startValue <= stopValue);
            ps *= Math.Cos(fa);
            double correction = -15.642 / ps;
            ps *= correction;

            return Math.Round(ps, 3);
        }
    }
}