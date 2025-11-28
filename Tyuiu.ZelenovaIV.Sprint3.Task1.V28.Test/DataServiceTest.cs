using Newtonsoft.Json.Linq;
using Tyuiu.ZelenovaIV.Sprint3.Task1.V28.Lib;

namespace Tyuiu.ZelenovaIV.Sprint3.Task1.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double Value = 0.5;
            int startValue = 1;
            int stopValue = 5;
            double result = ds.GetSumSeries(Value, startValue, stopValue);

            Assert.IsNotNull(result);
        }

    }
}
