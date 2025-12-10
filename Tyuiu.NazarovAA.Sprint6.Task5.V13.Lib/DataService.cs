using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task5.V13.Lib
{
    public class DataService : ISprint6Task5V13
    {
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    len++;
                }
            }

            double[] numbers = new double[len];

            using (StreamReader reader = new StreamReader(path))
            {
                int index = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numbers[index++] = double.Parse(line);
                }
            }

            numbers = numbers.Where(n => n < 10).ToArray();

            return numbers;
        }
    }
}
