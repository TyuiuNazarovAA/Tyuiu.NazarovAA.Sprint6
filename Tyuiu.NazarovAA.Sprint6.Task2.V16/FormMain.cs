using Tyuiu.NazarovAA.Sprint6.Task2.V16.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_NAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxInputStart_NAA.Text);
                int endStep = int.Parse(textBoxInputEnd_NAA.Text);

                double[] mas = ds.GetMassFunction(startStep, endStep);

                int len = endStep - startStep + 1;

                chartFunction.Titles.Add("График функции");

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisX.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridViewFunction.Rows.Add(startStep, mas[i]);

                    chartFunction.Series[0].Points.AddXY(startStep, mas[i]);

                    startStep++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные входные данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_NAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб 25-1 Назаров Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
