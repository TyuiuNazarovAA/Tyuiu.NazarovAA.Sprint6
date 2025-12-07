using Tyuiu.NazarovAA.Sprint6.Task0.V27.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task0.V27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                outputTextBox_NAA.Text = ds.Calculate(int.Parse(inputTextBox_NAA.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputTextBox_NAA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonInfo_NAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб 25-1 Назаров Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
