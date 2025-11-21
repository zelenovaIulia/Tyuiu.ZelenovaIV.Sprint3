using Tyuiu.ZelenovaIV.Sprint3.Task0.V16.Lib;

namespace Tyuiu.ZelenovaIV.Sprint3.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaidExpression()
        {
            DataService ds = new DataService();
            int value = 2;
            int valueStart = 1; 
            int valueStop = 2;
            Assert.AreEqual(ds.GetMultiplySeries(value, valueStart, valueStop), 8);
        }
    }
}
