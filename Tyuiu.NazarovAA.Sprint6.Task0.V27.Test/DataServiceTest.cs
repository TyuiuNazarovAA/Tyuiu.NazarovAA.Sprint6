using Tyuiu.NazarovAA.Sprint6.Task0.V27.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(4);

            double wait = -6;

            Assert.AreEqual(wait, result);
        }
    }
}
