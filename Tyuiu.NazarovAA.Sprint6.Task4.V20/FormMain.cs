using Tyuiu.NazarovAA.Sprint6.Task4.V20.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task4.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        public void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxInputStart.Text);
                int stopStep = int.Parse(textBoxInputEnd.Text);

                double[] mas = ds.GetMassFunction(startStep, stopStep);

                chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput.Text = "";

                chartFunction.Series[0].Points.Clear();

                int x = startStep;
                for (int i = 0; i < mas.Length; i++)
                {
                    chartFunction.Series[0].Points.AddXY(x, mas[i]);
                    textBoxOutput.AppendText(mas[i] + Environment.NewLine);
                    x++;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Некорректные входные данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonSave_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutputFileTask4.txt");
            File.WriteAllText(path, textBoxOutput.Text);

            DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.txt";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
        }

        public void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы РППб 25-1 Назаров Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
