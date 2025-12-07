using Tyuiu.NazarovAA.Sprint6.Task1.V9.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ds = new DataService();
        }
        DataService ds;

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int start = int.Parse(inputStartTextBox_NAA.Text);
                int end = int.Parse(inputEndTextBox_NAA.Text);

                double[] mas = ds.GetMassFunction(start, end);

                string result = "+----------+----------+" + Environment.NewLine;

                for (int i = start; i <= end; i++)
                {
                    result += String.Format("|{0,5:d}     |{1,8:f2}  |", i, mas[i + end]) + Environment.NewLine;
                }

                result += "+----------+----------+" + Environment.NewLine;

                outPutTextBox.Text = result;
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректные входные данные", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб 25-1 Назаров Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
