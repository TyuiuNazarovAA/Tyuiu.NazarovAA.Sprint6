using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] mas = new double[stopValue - startValue + 1];

            int x = startValue;

            for (int i = 0; i < mas.Length; i++)
            {
                if (x - 0.4 == 0)
                    mas[i] = 0;
                else
                    mas[i] = Math.Round(Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2, 2);
                x++;
            }

            return mas;
        }
    }
}
