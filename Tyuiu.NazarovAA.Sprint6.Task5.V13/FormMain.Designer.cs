namespace Tyuiu.NazarovAA.Sprint6.Task5.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonInfo = new Button();
            buttonFile = new Button();
            buttonDone = new Button();
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewOutput = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            splitter1 = new Splitter();
            panel3 = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonFile);
            panel1.Controls.Add(buttonDone);
            panel1.Controls.Add(groupBoxTask);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.Location = new Point(681, 26);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(99, 53);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonFile
            // 
            buttonFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFile.Location = new Point(567, 26);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(99, 53);
            buttonFile.TabIndex = 1;
            buttonFile.Text = "Открыть файл";
            buttonFile.UseVisualStyleBackColor = true;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.Location = new Point(451, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(99, 53);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(328, 88);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(302, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла, вывести значения меньше 10 в DataGridView";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(groupBoxOutput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 356);
            panel2.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(160, 356);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.ColumnHeadersVisible = false;
            dataGridViewOutput.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewOutput.Dock = DockStyle.Fill;
            dataGridViewOutput.Location = new Point(3, 23);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.RowHeadersWidth = 51;
            dataGridViewOutput.Size = new Size(154, 330);
            dataGridViewOutput.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 25;
            // 
            // Y
            // 
            Y.HeaderText = "";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(160, 94);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 356);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(chartFunction);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(164, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 356);
            panel3.TabIndex = 3;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(0, 0);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(636, 356);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel3;
        private GroupBox groupBoxTask;
        private TextBox textBox1;
        private Button buttonInfo;
        private Button buttonFile;
        private Button buttonDone;
        private DataGridView dataGridViewOutput;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private GroupBox groupBoxOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
