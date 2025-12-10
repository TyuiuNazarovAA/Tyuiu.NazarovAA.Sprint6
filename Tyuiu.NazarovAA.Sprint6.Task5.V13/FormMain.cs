using Tyuiu.NazarovAA.Sprint6.Task5.V13.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task5.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\epiccipe\source\repos\Tyuiu.NazarovAA.Sprint6\Tyuiu.NazarovAA.Sprint6.Task5.V13\bin\Debug\InPutDataFileTask5V13.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOutput.ColumnCount = 2;
                dataGridViewOutput.Columns[0].Width = 30;
                dataGridViewOutput.Columns[1].Width = 60;

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                dataGridViewOutput.Rows.Clear();
                chartFunction.Series[0].Points.Clear();

                double[] nums = ds.LoadFromDataFile(path);

                for (int i = 0; i < nums.Length; i++)
                {
                    dataGridViewOutput.Rows.Add(i, nums[i]);
                    chartFunction.Series[0].Points.AddXY(i, nums[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректный путь", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Файл не найден", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы РППб 25-1 Назаров Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
