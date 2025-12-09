using Tyuiu.NazarovAA.Sprint6.Task3.V12.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] inputMatrix =
            {
                { -6, -13, -1, -7, 10 },
                { 14, -18, 18, 1, 11 },
                { -2, -17, -15, -10, -8 },
                { 19, -4, -6, -11, 8 },
                { -17, 17, 14, 13, 19 }
            };
        private void buttonDone_Click(object sender, EventArgs e)
        {
            int rows = inputMatrix.GetUpperBound(0) + 1;
            int columns = inputMatrix.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 45;
            }

            ds.Calculate(inputMatrix);

            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = inputMatrix[i, j];
                }
            }
        }
        public void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы РППб 25-1 Назаров Артём Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
