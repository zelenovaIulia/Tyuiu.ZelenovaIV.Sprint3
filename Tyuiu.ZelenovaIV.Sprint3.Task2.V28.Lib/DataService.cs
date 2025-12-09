using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZelenovaIV.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 0;
            var k = startValue;
            do
            {
                result = (Math.Pow(2, k) / (k + 1)) * Math.Cos(1.8);
                k++;
            } while (k < stopValue);

            return result;
        }
    }
}