namespace Tyuiu.NazarovAA.Sprint6.Task1.V9
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            inputEndTextBox_NAA = new TextBox();
            inputStartTextBox_NAA = new TextBox();
            groupBox3 = new GroupBox();
            outPutTextBox = new TextBox();
            buttonInfo = new Button();
            buttonDone = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(365, 40);
            label1.TabIndex = 0;
            label1.Text = "Преобразовать функцию  на заданном диапазоне.\r\nРезультат вывести в виде таблицы\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(inputEndTextBox_NAA);
            groupBox2.Controls.Add(inputStartTextBox_NAA);
            groupBox2.Location = new Point(21, 340);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 98);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 42);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Конец шага";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 2;
            label2.Text = "Старт шага";
            // 
            // inputEndTextBox_NAA
            // 
            inputEndTextBox_NAA.Location = new Point(120, 65);
            inputEndTextBox_NAA.Name = "inputEndTextBox_NAA";
            inputEndTextBox_NAA.Size = new Size(97, 27);
            inputEndTextBox_NAA.TabIndex = 1;
            // 
            // inputStartTextBox_NAA
            // 
            inputStartTextBox_NAA.Location = new Point(6, 65);
            inputStartTextBox_NAA.Name = "inputStartTextBox_NAA";
            inputStartTextBox_NAA.Size = new Size(97, 27);
            inputStartTextBox_NAA.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(outPutTextBox);
            groupBox3.Location = new Point(504, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(267, 418);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // outPutTextBox
            // 
            outPutTextBox.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            outPutTextBox.Location = new Point(6, 26);
            outPutTextBox.Multiline = true;
            outPutTextBox.Name = "outPutTextBox";
            outPutTextBox.ReadOnly = true;
            outPutTextBox.Size = new Size(255, 373);
            outPutTextBox.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(254, 357);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(92, 71);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(352, 357);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(146, 71);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonInfo);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox inputEndTextBox_NAA;
        private TextBox inputStartTextBox_NAA;
        private GroupBox groupBox3;
        private TextBox outPutTextBox;
        private Button buttonInfo;
        private Button buttonDone;
    }
}
