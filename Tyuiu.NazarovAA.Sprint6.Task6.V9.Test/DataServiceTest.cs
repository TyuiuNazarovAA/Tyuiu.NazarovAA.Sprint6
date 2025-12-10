using Tyuiu.NazarovAA.Sprint6.Task6.V9.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckResult()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\epiccipe\source\repos\Tyuiu.NazarovAA.Sprint6\Tyuiu.NazarovAA.Sprint6.Task6.V9\bin\Debug\InPutDataFileTask6V9.txt";

            string result = ds.CollectTextFromFile(path);

            string wait = "DvbkNN MPO GEzUiEPbamDblZ jKVWBlKg QzObVnRejHHXCeP";

            Assert.AreEqual(wait, result);
        }
    }
}
