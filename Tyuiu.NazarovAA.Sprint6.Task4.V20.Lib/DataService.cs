using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;

            double[] mas = new double[len];

            int x = startValue;

            for (int i = 0; i < len; i++)
            {
                if (3 * x - 1 == 0)
                    mas[i] = 0;
                else
                    mas[i] = Math.Round((Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2, 2);
                x++;
            }

            return mas;
        }
    }
}
