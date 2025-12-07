using Tyuiu.NazarovAA.Sprint6.Task1.V9.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            double[] wait = new double[] { -19.62, -17.12, -18.15, -63.13, -24.92, -5, -1.46, 1.57, 6.38, 32.78, 225.11 };
            double[] res = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
