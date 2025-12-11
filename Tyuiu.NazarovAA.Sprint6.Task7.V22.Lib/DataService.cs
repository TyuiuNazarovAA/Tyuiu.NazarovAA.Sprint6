using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task7.V22.Lib
{
    public class DataService : ISprint6Task7V22
    {
        public int[,] GetMatrix(string path)
        {
            string data = File.ReadAllText(path);

            string[] rowsMas = data.Split("\n");

            int rows = rowsMas.Where(s => !string.IsNullOrEmpty(s)).ToArray().Length;
            int columns = rowsMas[0].Split(";").Length;

            int[,] matrix = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                string currentRow = rowsMas[i];
                for (int j = 0; j < columns; j++)
                {
                    int number = int.Parse(currentRow.Split(";")[j]);
                    if (number > 0 && number % 2 == 0 && j == 5)
                        matrix[i, j] = 111;
                    else
                        matrix[i, j] = number;
                }
            }

            return matrix;
        }
    }
}
