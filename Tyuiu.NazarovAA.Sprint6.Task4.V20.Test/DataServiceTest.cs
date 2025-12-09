using Tyuiu.NazarovAA.Sprint6.Task4.V20.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculation()
        {
            DataService ds = new DataService();

            double[] wait = {
                17.27,
                14.08,
                10.27,
                6.65,
                3.87,
                2,
                -0.74,
                -3.71,
                -7.59,
                -11.55,
                -14.74,
            };

            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
