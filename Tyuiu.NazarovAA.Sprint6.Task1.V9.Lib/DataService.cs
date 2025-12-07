using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task1.V9.Lib
{
    public class DataService : ISprint6Task1V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mas = new double[stopValue - startValue + 1];

            int x = startValue;

            for (int i = 0; i < mas.Length; i++)
            {
                if (Math.Sin(x) + 1 == 0)
                    mas[i] = 0;
                else
                    mas[i] = Math.Round(2 * x - 4 + (2 * x - 1) / (Math.Sin(x) + 1), 2);
                x++;
            }

            return mas;
        }
    }
}
