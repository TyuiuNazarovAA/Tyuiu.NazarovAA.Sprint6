namespace Tyuiu.NazarovAA.Sprint6.Task6.V9
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            panel4 = new Panel();
            groupBoxOut = new GroupBox();
            textBoxOut = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxIn.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxOut.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 108);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackgroundImage = (Image)resources.GetObject("buttonInfo.BackgroundImage");
            buttonInfo.BackgroundImageLayout = ImageLayout.Stretch;
            buttonInfo.Font = new Font("Segoe UI", 9F);
            buttonInfo.Location = new Point(895, 3);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(100, 100);
            buttonInfo.TabIndex = 0;
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = (Image)resources.GetObject("buttonDone.BackgroundImage");
            buttonDone.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(109, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(100, 100);
            buttonDone.TabIndex = 0;
            toolTip.SetToolTip(buttonDone, "Вывести последнее слово каждой строки");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackgroundImage = (Image)resources.GetObject("buttonOpenFile.BackgroundImage");
            buttonOpenFile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile.Location = new Point(3, 3);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(100, 100);
            buttonOpenFile.TabIndex = 0;
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 133);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(998, 133);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 23);
            textBox1.Margin = new Padding(10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(992, 107);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxIn);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 241);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 366);
            panel3.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(491, 366);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 23);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.Size = new Size(485, 340);
            textBoxIn.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOut);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(491, 241);
            panel4.Name = "panel4";
            panel4.Size = new Size(507, 366);
            panel4.TabIndex = 3;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(507, 366);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 23);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.Size = new Size(501, 340);
            textBoxOut.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(491, 241);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 366);
            splitter1.TabIndex = 4;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 607);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Splitter splitter1;
        private Button buttonInfo;
        private Button buttonDone;
        private Button buttonOpenFile;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogTask;
    }
}
