using Tyuiu.NazarovAA.Sprint6.Task7.V22.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task7.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения разделённые запятыми(*.csv)|*.csv|Все файлы (*.*)|*.*";
            saveFileDialogTask.Filter = "Значения разделённые запятыми(*.csv)|*.csv|Все файлы (*.*)|*.*";
        }

        DataService ds = new DataService();
        string openFilePath;

        static int rows;
        static int columns;
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            try
            {
                int[,] matrix = LoadMatrix(openFilePath);
                dataGridViewIn.ColumnCount = columns;
                dataGridViewIn.RowCount = rows;
                dataGridViewOut.ColumnCount = columns;
                dataGridViewOut.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewIn.Columns[i].Width = 35;
                    dataGridViewOut.Columns[i].Width = 35;
                }

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewIn.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }

                buttonDone.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно указан путь", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int[,] LoadMatrix(string path)
        {
            string data = File.ReadAllText(path);

            string[] lines = data.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(";").Length;


            int[,] inputMatrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");

                for (int j = 0; j < columns; j++)
                {
                    inputMatrix[i, j] = int.Parse(line[j]);
                }
            }

            return inputMatrix;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] doneMatrix = ds.GetMatrix(openFilePath);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = doneMatrix[i, j];
                }
            }

            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutDataFileTask7V22.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;
            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == columns - 1)
                        str += dataGridViewOut.Rows[i].Cells[j].Value;
                    else
                        str += dataGridViewOut.Rows[i].Cells[j].Value + ";";
                }
                str += "\n";
            }

            File.AppendAllText(path, str + Environment.NewLine);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
