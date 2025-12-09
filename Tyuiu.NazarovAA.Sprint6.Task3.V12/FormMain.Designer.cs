namespace Tyuiu.NazarovAA.Sprint6.Task3.V12
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
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            dataGridViewMatrix = new DataGridView();
            groupBoxOutput = new GroupBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(386, 257);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(367, 223);
            textBox1.TabIndex = 0;
            textBox1.Text = "-6 -13  -1  -7  10\r\n\r\n  14 -18  18   1  11\r\n\r\n  -2 -17 -15 -10  -8\r\n\r\n  19  -4  -6 -11   8\r\n\r\n -17  17  14  13  19\r\nЗаменить четные значения в первой строке на 0.";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(25, 26);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(281, 283);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewMatrix);
            groupBoxOutput.Location = new Point(391, 10);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(322, 326);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(259, 283);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(126, 54);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(184, 282);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(63, 54);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += this.buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 349);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            Controls.Add(buttonInfo);
            Name = "FormMain";
            Text = "Form1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBox1;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxOutput;
        private Button buttonDone;
        private Button buttonInfo;
    }
}
