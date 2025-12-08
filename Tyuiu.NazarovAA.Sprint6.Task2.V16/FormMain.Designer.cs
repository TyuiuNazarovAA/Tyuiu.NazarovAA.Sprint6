namespace Tyuiu.NazarovAA.Sprint6.Task2.V16
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxInputEnd_NAA = new TextBox();
            textBoxInputStart_NAA = new TextBox();
            buttonDone_NAA = new Button();
            buttonInfo_NAA = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(388, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(363, 125);
            textBox1.TabIndex = 0;
            textBox1.Text = "Написать программу которая выводит таблицы значений функции";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewFunction);
            groupBox2.Controls.Add(chartFunction);
            groupBox2.Location = new Point(406, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(512, 336);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction.Location = new Point(17, 26);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(130, 293);
            dataGridViewFunction.TabIndex = 2;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(163, 26);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(360, 304);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxInputEnd_NAA);
            groupBox3.Controls.Add(textBoxInputStart_NAA);
            groupBox3.Location = new Point(12, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 153);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 78);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 3;
            label2.Text = "Конец шага";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 78);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 2;
            label1.Text = "Старт шага";
            // 
            // textBoxInputEnd_NAA
            // 
            textBoxInputEnd_NAA.Location = new Point(141, 111);
            textBoxInputEnd_NAA.Name = "textBoxInputEnd_NAA";
            textBoxInputEnd_NAA.Size = new Size(104, 27);
            textBoxInputEnd_NAA.TabIndex = 1;
            // 
            // textBoxInputStart_NAA
            // 
            textBoxInputStart_NAA.Location = new Point(15, 111);
            textBoxInputStart_NAA.Name = "textBoxInputStart_NAA";
            textBoxInputStart_NAA.Size = new Size(104, 27);
            textBoxInputStart_NAA.TabIndex = 0;
            // 
            // buttonDone_NAA
            // 
            buttonDone_NAA.Location = new Point(281, 286);
            buttonDone_NAA.Name = "buttonDone_NAA";
            buttonDone_NAA.Size = new Size(108, 56);
            buttonDone_NAA.TabIndex = 0;
            buttonDone_NAA.Text = "Выполнить";
            buttonDone_NAA.UseVisualStyleBackColor = true;
            buttonDone_NAA.Click += buttonDone_NAA_Click;
            // 
            // buttonInfo_NAA
            // 
            buttonInfo_NAA.Location = new Point(281, 208);
            buttonInfo_NAA.Name = "buttonInfo_NAA";
            buttonInfo_NAA.Size = new Size(108, 56);
            buttonInfo_NAA.TabIndex = 3;
            buttonInfo_NAA.Text = "Справка";
            buttonInfo_NAA.UseVisualStyleBackColor = true;
            buttonInfo_NAA.Click += buttonInfo_NAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 370);
            Controls.Add(buttonInfo_NAA);
            Controls.Add(buttonDone_NAA);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private TextBox textBoxInputEnd_NAA;
        private TextBox textBoxInputStart_NAA;
        private Button buttonDone_NAA;
        private Button buttonInfo_NAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private DataGridViewTextBoxColumn Column1;
    }
}
