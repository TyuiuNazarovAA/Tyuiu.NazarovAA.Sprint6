namespace Tyuiu.NazarovAA.Sprint6.Task0.V27
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inputTextBox_NAA = new TextBox();
            buttonDone_NAA = new Button();
            outputTextBox_NAA = new TextBox();
            pictureBoxFormule_NAA = new PictureBox();
            textBoxTask_NAA = new TextBox();
            groupBoxTask_NAA = new GroupBox();
            labelX_NAA = new Label();
            groupBoxInput_NAA = new GroupBox();
            groupBoxOutput_NAA = new GroupBox();
            labelResult = new Label();
            buttonInfo_NAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule_NAA).BeginInit();
            groupBoxTask_NAA.SuspendLayout();
            groupBoxInput_NAA.SuspendLayout();
            groupBoxOutput_NAA.SuspendLayout();
            SuspendLayout();
            // 
            // inputTextBox_NAA
            // 
            inputTextBox_NAA.Location = new Point(17, 59);
            inputTextBox_NAA.Name = "inputTextBox_NAA";
            inputTextBox_NAA.Size = new Size(125, 27);
            inputTextBox_NAA.TabIndex = 0;
            inputTextBox_NAA.KeyPress += inputTextBox_NAA_KeyPress;
            // 
            // buttonDone_NAA
            // 
            buttonDone_NAA.Location = new Point(660, 384);
            buttonDone_NAA.Name = "buttonDone_NAA";
            buttonDone_NAA.Size = new Size(112, 43);
            buttonDone_NAA.TabIndex = 1;
            buttonDone_NAA.Text = "Выполнить";
            buttonDone_NAA.UseVisualStyleBackColor = true;
            buttonDone_NAA.Click += buttonDone_Click;
            // 
            // outputTextBox_NAA
            // 
            outputTextBox_NAA.Location = new Point(21, 59);
            outputTextBox_NAA.Name = "outputTextBox_NAA";
            outputTextBox_NAA.ReadOnly = true;
            outputTextBox_NAA.Size = new Size(125, 27);
            outputTextBox_NAA.TabIndex = 2;
            // 
            // pictureBoxFormule_NAA
            // 
            pictureBoxFormule_NAA.Image = (Image)resources.GetObject("pictureBoxFormule_NAA.Image");
            pictureBoxFormule_NAA.Location = new Point(426, 26);
            pictureBoxFormule_NAA.Name = "pictureBoxFormule_NAA";
            pictureBoxFormule_NAA.Size = new Size(334, 66);
            pictureBoxFormule_NAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFormule_NAA.TabIndex = 3;
            pictureBoxFormule_NAA.TabStop = false;
            // 
            // textBoxTask_NAA
            // 
            textBoxTask_NAA.Location = new Point(19, 26);
            textBoxTask_NAA.Multiline = true;
            textBoxTask_NAA.Name = "textBoxTask_NAA";
            textBoxTask_NAA.ReadOnly = true;
            textBoxTask_NAA.Size = new Size(392, 193);
            textBoxTask_NAA.TabIndex = 5;
            textBoxTask_NAA.Text = "Вычислить значение по формуле";
            // 
            // groupBoxTask_NAA
            // 
            groupBoxTask_NAA.Controls.Add(textBoxTask_NAA);
            groupBoxTask_NAA.Controls.Add(pictureBoxFormule_NAA);
            groupBoxTask_NAA.Location = new Point(12, 12);
            groupBoxTask_NAA.Name = "groupBoxTask_NAA";
            groupBoxTask_NAA.Size = new Size(776, 240);
            groupBoxTask_NAA.TabIndex = 6;
            groupBoxTask_NAA.TabStop = false;
            groupBoxTask_NAA.Text = "Условие";
            // 
            // labelX_NAA
            // 
            labelX_NAA.AutoSize = true;
            labelX_NAA.Location = new Point(19, 29);
            labelX_NAA.Name = "labelX_NAA";
            labelX_NAA.Size = new Size(111, 20);
            labelX_NAA.TabIndex = 7;
            labelX_NAA.Text = "Переменная X";
            // 
            // groupBoxInput_NAA
            // 
            groupBoxInput_NAA.Controls.Add(labelX_NAA);
            groupBoxInput_NAA.Controls.Add(inputTextBox_NAA);
            groupBoxInput_NAA.Location = new Point(12, 258);
            groupBoxInput_NAA.Name = "groupBoxInput_NAA";
            groupBoxInput_NAA.Size = new Size(384, 107);
            groupBoxInput_NAA.TabIndex = 8;
            groupBoxInput_NAA.TabStop = false;
            groupBoxInput_NAA.Text = "Ввод данных";
            // 
            // groupBoxOutput_NAA
            // 
            groupBoxOutput_NAA.Controls.Add(labelResult);
            groupBoxOutput_NAA.Controls.Add(outputTextBox_NAA);
            groupBoxOutput_NAA.Location = new Point(402, 258);
            groupBoxOutput_NAA.Name = "groupBoxOutput_NAA";
            groupBoxOutput_NAA.Size = new Size(386, 107);
            groupBoxOutput_NAA.TabIndex = 9;
            groupBoxOutput_NAA.TabStop = false;
            groupBoxOutput_NAA.Text = "Вывод данных";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(21, 29);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(75, 20);
            labelResult.TabIndex = 3;
            labelResult.Text = "Результат";
            // 
            // buttonInfo_NAA
            // 
            buttonInfo_NAA.FlatStyle = FlatStyle.Flat;
            buttonInfo_NAA.Location = new Point(603, 384);
            buttonInfo_NAA.Name = "buttonInfo_NAA";
            buttonInfo_NAA.Size = new Size(51, 43);
            buttonInfo_NAA.TabIndex = 11;
            buttonInfo_NAA.Text = "?";
            buttonInfo_NAA.UseVisualStyleBackColor = true;
            buttonInfo_NAA.Click += buttonInfo_NAA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_NAA);
            Controls.Add(groupBoxOutput_NAA);
            Controls.Add(groupBoxInput_NAA);
            Controls.Add(groupBoxTask_NAA);
            Controls.Add(buttonDone_NAA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormule_NAA).EndInit();
            groupBoxTask_NAA.ResumeLayout(false);
            groupBoxTask_NAA.PerformLayout();
            groupBoxInput_NAA.ResumeLayout(false);
            groupBoxInput_NAA.PerformLayout();
            groupBoxOutput_NAA.ResumeLayout(false);
            groupBoxOutput_NAA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox inputTextBox_NAA;
        private Button buttonDone_NAA;
        private TextBox outputTextBox_NAA;
        private PictureBox pictureBoxFormule_NAA;
        private TextBox textBoxTask_NAA;
        private GroupBox groupBoxTask_NAA;
        private Label labelX_NAA;
        private GroupBox groupBoxInput_NAA;
        private GroupBox groupBoxOutput_NAA;
        private Label labelResult;
        private Button button1;
        private Button buttonInfo_NAA;
    }
}
