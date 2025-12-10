using Tyuiu.NazarovAA.Sprint6.Task5.V13.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckResult()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\epiccipe\source\repos\Tyuiu.NazarovAA.Sprint6\Tyuiu.NazarovAA.Sprint6.Task5.V13\bin\Debug\InPutDataFileTask5V13.txt";

            double[] result = ds.LoadFromDataFile(path);

            double[] wait = { -13, -19, -9.82, -9.71, 3.36, 0.48, 4.13, -0.11, -17.36, -12, -12.35 };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
