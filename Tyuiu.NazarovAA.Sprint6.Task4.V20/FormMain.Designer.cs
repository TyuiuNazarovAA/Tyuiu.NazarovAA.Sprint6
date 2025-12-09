namespace Tyuiu.NazarovAA.Sprint6.Task4.V20
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxOutput = new GroupBox();
            textBoxOutput = new TextBox();
            groupBoxGraph = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxInput = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxInputEnd = new TextBox();
            textBoxInputStart = new TextBox();
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            buttonInfo = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBoxOutput.SuspendLayout();
            groupBoxGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutput);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(352, 339);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxOutput
            // 
            textBoxOutput.Dock = DockStyle.Fill;
            textBoxOutput.Location = new Point(3, 23);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.ScrollBars = ScrollBars.Vertical;
            textBoxOutput.Size = new Size(346, 313);
            textBoxOutput.TabIndex = 0;
            // 
            // groupBoxGraph
            // 
            groupBoxGraph.Controls.Add(chartFunction);
            groupBoxGraph.Dock = DockStyle.Fill;
            groupBoxGraph.Location = new Point(0, 0);
            groupBoxGraph.Name = "groupBoxGraph";
            groupBoxGraph.Size = new Size(630, 339);
            groupBoxGraph.TabIndex = 0;
            groupBoxGraph.TabStop = false;
            groupBoxGraph.Text = "График";
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea2);
            chartFunction.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFunction.Legends.Add(legend2);
            chartFunction.Location = new Point(3, 23);
            chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction.Series.Add(series2);
            chartFunction.Size = new Size(624, 313);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "График функции";
            chartFunction.Titles.Add(title2);
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(label2);
            groupBoxInput.Controls.Add(label1);
            groupBoxInput.Controls.Add(textBoxInputEnd);
            groupBoxInput.Controls.Add(textBoxInputStart);
            groupBoxInput.Location = new Point(340, 3);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(319, 105);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 42);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Конец шага";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Старт шага";
            // 
            // textBoxInputEnd
            // 
            textBoxInputEnd.Location = new Point(172, 65);
            textBoxInputEnd.Name = "textBoxInputEnd";
            textBoxInputEnd.Size = new Size(125, 27);
            textBoxInputEnd.TabIndex = 1;
            // 
            // textBoxInputStart
            // 
            textBoxInputStart.Location = new Point(6, 65);
            textBoxInputStart.Name = "textBoxInputStart";
            textBoxInputStart.Size = new Size(125, 27);
            textBoxInputStart.TabIndex = 0;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(334, 114);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(304, 70);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вывод таблицы значений функции и запись данных в файл";
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.Location = new Point(706, 12);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(59, 65);
            buttonInfo.TabIndex = 1;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Location = new Point(771, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 65);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.Location = new Point(874, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(97, 65);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask);
            panel1.Controls.Add(groupBoxInput);
            panel1.Controls.Add(buttonInfo);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonDone);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 114);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(352, 339);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxGraph);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(352, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(630, 339);
            panel3.TabIndex = 4;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1000, 500);
            Name = "FormMain";
            Text = "Form1";
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            groupBoxGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBoxOutput;
        private GroupBox groupBoxGraph;
        private TextBox textBoxOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private GroupBox groupBoxInput;
        private Label label2;
        private Label label1;
        private TextBox textBoxInputEnd;
        private TextBox textBoxInputStart;
        private GroupBox groupBoxTask;
        private TextBox textBox1;
        private Button buttonInfo;
        private Button buttonSave;
        private Button buttonDone;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}
