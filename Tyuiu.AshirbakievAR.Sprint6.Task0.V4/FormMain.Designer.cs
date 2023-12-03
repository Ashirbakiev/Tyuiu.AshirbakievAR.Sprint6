
namespace Tyuiu.AshirbakievAR.Sprint6.Task0.V4
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxInfo_AAR = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_AAR = new System.Windows.Forms.TextBox();
            this.groupBoxData_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxInputX = new System.Windows.Forms.TextBox();
            this.labelX_AAR = new System.Windows.Forms.Label();
            this.groupBoxResult_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxOutputX_AAR = new System.Windows.Forms.TextBox();
            this.labelResult_AAR = new System.Windows.Forms.Label();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.groupBoxInfo_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxData_AAR.SuspendLayout();
            this.groupBoxResult_AAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo_AAR
            // 
            this.groupBoxInfo_AAR.Controls.Add(this.pictureBoxFormula);
            this.groupBoxInfo_AAR.Controls.Add(this.textBoxInfo_AAR);
            this.groupBoxInfo_AAR.Location = new System.Drawing.Point(16, 12);
            this.groupBoxInfo_AAR.Name = "groupBoxInfo_AAR";
            this.groupBoxInfo_AAR.Size = new System.Drawing.Size(772, 222);
            this.groupBoxInfo_AAR.TabIndex = 0;
            this.groupBoxInfo_AAR.TabStop = false;
            this.groupBoxInfo_AAR.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(482, 19);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(284, 39);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxInfo_AAR
            // 
            this.textBoxInfo_AAR.Location = new System.Drawing.Point(6, 19);
            this.textBoxInfo_AAR.Multiline = true;
            this.textBoxInfo_AAR.Name = "textBoxInfo_AAR";
            this.textBoxInfo_AAR.ReadOnly = true;
            this.textBoxInfo_AAR.Size = new System.Drawing.Size(236, 45);
            this.textBoxInfo_AAR.TabIndex = 0;
            this.textBoxInfo_AAR.Text = "Дано выражение вычислить его значение при x = 3. Округлить до трёх знаков после з" +
    "";
            // 
            // groupBoxData_AAR
            // 
            this.groupBoxData_AAR.Controls.Add(this.textBoxInputX);
            this.groupBoxData_AAR.Controls.Add(this.labelX_AAR);
            this.groupBoxData_AAR.Location = new System.Drawing.Point(16, 240);
            this.groupBoxData_AAR.Name = "groupBoxData_AAR";
            this.groupBoxData_AAR.Size = new System.Drawing.Size(449, 163);
            this.groupBoxData_AAR.TabIndex = 1;
            this.groupBoxData_AAR.TabStop = false;
            this.groupBoxData_AAR.Text = "Ввод данных";
            // 
            // textBoxInputX
            // 
            this.textBoxInputX.Location = new System.Drawing.Point(6, 42);
            this.textBoxInputX.Name = "textBoxInputX";
            this.textBoxInputX.Size = new System.Drawing.Size(59, 20);
            this.textBoxInputX.TabIndex = 1;
            this.textBoxInputX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputX_KeyPress);
            // 
            // labelX_AAR
            // 
            this.labelX_AAR.AutoSize = true;
            this.labelX_AAR.Location = new System.Drawing.Point(3, 26);
            this.labelX_AAR.Name = "labelX_AAR";
            this.labelX_AAR.Size = new System.Drawing.Size(62, 13);
            this.labelX_AAR.TabIndex = 0;
            this.labelX_AAR.Text = "Введите X:";
            // 
            // groupBoxResult_AAR
            // 
            this.groupBoxResult_AAR.Controls.Add(this.textBoxOutputX_AAR);
            this.groupBoxResult_AAR.Controls.Add(this.labelResult_AAR);
            this.groupBoxResult_AAR.Location = new System.Drawing.Point(471, 240);
            this.groupBoxResult_AAR.Name = "groupBoxResult_AAR";
            this.groupBoxResult_AAR.Size = new System.Drawing.Size(317, 163);
            this.groupBoxResult_AAR.TabIndex = 2;
            this.groupBoxResult_AAR.TabStop = false;
            this.groupBoxResult_AAR.Text = "Вывод данных";
            // 
            // textBoxOutputX_AAR
            // 
            this.textBoxOutputX_AAR.Location = new System.Drawing.Point(9, 42);
            this.textBoxOutputX_AAR.Name = "textBoxOutputX_AAR";
            this.textBoxOutputX_AAR.ReadOnly = true;
            this.textBoxOutputX_AAR.Size = new System.Drawing.Size(302, 20);
            this.textBoxOutputX_AAR.TabIndex = 1;
            // 
            // labelResult_AAR
            // 
            this.labelResult_AAR.AutoSize = true;
            this.labelResult_AAR.Location = new System.Drawing.Point(6, 26);
            this.labelResult_AAR.Name = "labelResult_AAR";
            this.labelResult_AAR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAR.TabIndex = 0;
            this.labelResult_AAR.Text = "Результат:";
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(686, 409);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(102, 35);
            this.buttonOutput.TabIndex = 3;
            this.buttonOutput.Text = "Выполнить";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonHelp_AAR
            // 
            this.buttonHelp_AAR.Location = new System.Drawing.Point(644, 409);
            this.buttonHelp_AAR.Name = "buttonHelp_AAR";
            this.buttonHelp_AAR.Size = new System.Drawing.Size(36, 35);
            this.buttonHelp_AAR.TabIndex = 4;
            this.buttonHelp_AAR.Text = "?";
            this.buttonHelp_AAR.UseVisualStyleBackColor = true;
            this.buttonHelp_AAR.Click += new System.EventHandler(this.buttonHelp_AAR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_AAR);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.groupBoxResult_AAR);
            this.Controls.Add(this.groupBoxData_AAR);
            this.Controls.Add(this.groupBoxInfo_AAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 17 | Аширбакиев А. Р.";
            this.groupBoxInfo_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxData_AAR.ResumeLayout(false);
            this.groupBoxData_AAR.PerformLayout();
            this.groupBoxResult_AAR.ResumeLayout(false);
            this.groupBoxResult_AAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_AAR;
        private System.Windows.Forms.TextBox textBoxInfo_AAR;
        private System.Windows.Forms.GroupBox groupBoxData_AAR;
        private System.Windows.Forms.GroupBox groupBoxResult_AAR;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.Label labelX_AAR;
        private System.Windows.Forms.Label labelResult_AAR;
        private System.Windows.Forms.TextBox textBoxInputX;
        private System.Windows.Forms.TextBox textBoxOutputX_AAR;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonHelp_AAR;
    }
}

