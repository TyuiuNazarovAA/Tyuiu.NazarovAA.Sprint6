using Tyuiu.NazarovAA.Sprint6.Task2.V16.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            double[] wait = new double[]
            {
                -36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.4, -36.3
            };

            double[] res = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
