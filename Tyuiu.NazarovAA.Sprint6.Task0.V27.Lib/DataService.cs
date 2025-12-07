using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task0.V27.Lib
{
    public class DataService : ISprint6Task0V27
    {
        public double Calculate(int x)
        {
            return Math.Round(-x * x * x + 4 * x * x - 3 / 2d * x, 3);
        }
    }
}
