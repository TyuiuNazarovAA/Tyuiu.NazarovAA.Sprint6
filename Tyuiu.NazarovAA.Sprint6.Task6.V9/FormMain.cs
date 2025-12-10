using Tyuiu.NazarovAA.Sprint6.Task6.V9.Lib;

namespace Tyuiu.NazarovAA.Sprint6.Task6.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxIn.Text = File.ReadAllText(openFilePath);
            groupBoxIn.Text = "¬вод " + openFilePath;
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
