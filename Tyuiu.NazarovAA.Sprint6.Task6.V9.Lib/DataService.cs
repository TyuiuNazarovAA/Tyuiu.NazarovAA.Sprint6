using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NazarovAA.Sprint6.Task6.V9.Lib
{
    public class DataService : ISprint6Task6V9
    {
        public string CollectTextFromFile(string path)
        {
            List<string> mas = new List<string>();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                {
                    mas.Add(line.Split()[line.Split().Length - 1]);
                }
            }

            return string.Join(" ", mas);
        }
    }
}
