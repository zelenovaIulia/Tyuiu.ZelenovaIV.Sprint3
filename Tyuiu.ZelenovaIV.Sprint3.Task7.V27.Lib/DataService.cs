using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZelenovaIV.Sprint3.Task7.V27.Lib
{
    public class DataService : ISprint3Task7V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = x + 1;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Round(Math.Cos(x) / denominator - Math.Cos(x) * 1.3 + 3 * x, 2);
                }
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}