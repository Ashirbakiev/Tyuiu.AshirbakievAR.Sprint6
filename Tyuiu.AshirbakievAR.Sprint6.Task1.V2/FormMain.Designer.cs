
namespace Tyuiu.AshirbakievAR.Sprint6.Task1.V2
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
            this.groupBoxInfo_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_AAR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_AAR = new System.Windows.Forms.GroupBox();
            this.groupBoxData_AAR = new System.Windows.Forms.GroupBox();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.buttonOutput_AAR = new System.Windows.Forms.Button();
            this.labelStart_AAR = new System.Windows.Forms.Label();
            this.labelEnd_AAR = new System.Windows.Forms.Label();
            this.textBoxStar_AAR = new System.Windows.Forms.TextBox();
            this.textBoxEnd_AAR = new System.Windows.Forms.TextBox();
            this.labelResult_AAR = new System.Windows.Forms.Label();
            this.textBoxResult_AAR = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_AAR.SuspendLayout();
            this.groupBoxResult_AAR.SuspendLayout();
            this.groupBoxData_AAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo_AAR
            // 
            this.groupBoxInfo_AAR.Controls.Add(this.textBoxInfo_AAR);
            this.groupBoxInfo_AAR.Location = new System.Drawing.Point(15, 16);
            this.groupBoxInfo_AAR.Name = "groupBoxInfo_AAR";
            this.groupBoxInfo_AAR.Size = new System.Drawing.Size(557, 346);
            this.groupBoxInfo_AAR.TabIndex = 0;
            this.groupBoxInfo_AAR.TabStop = false;
            this.groupBoxInfo_AAR.Text = "Условие";
            // 
            // textBoxInfo_AAR
            // 
            this.textBoxInfo_AAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_AAR.Location = new System.Drawing.Point(6, 19);
            this.textBoxInfo_AAR.Multiline = true;
            this.textBoxInfo_AAR.Name = "textBoxInfo_AAR";
            this.textBoxInfo_AAR.ReadOnly = true;
            this.textBoxInfo_AAR.Size = new System.Drawing.Size(296, 91);
            this.textBoxInfo_AAR.TabIndex = 1;
            this.textBoxInfo_AAR.Text = "Протабулировать функцию (5X+2,5)/(SIN(X)+2)+2X+2 на заданном диапазоне.Результат " +
    "вывести в таблице.";
            // 
            // groupBoxResult_AAR
            // 
            this.groupBoxResult_AAR.Controls.Add(this.textBoxResult_AAR);
            this.groupBoxResult_AAR.Controls.Add(this.labelResult_AAR);
            this.groupBoxResult_AAR.Location = new System.Drawing.Point(584, 16);
            this.groupBoxResult_AAR.Name = "groupBoxResult_AAR";
            this.groupBoxResult_AAR.Size = new System.Drawing.Size(268, 422);
            this.groupBoxResult_AAR.TabIndex = 1;
            this.groupBoxResult_AAR.TabStop = false;
            this.groupBoxResult_AAR.Text = "Вывод данных";
            // 
            // groupBoxData_AAR
            // 
            this.groupBoxData_AAR.Controls.Add(this.textBoxEnd_AAR);
            this.groupBoxData_AAR.Controls.Add(this.textBoxStar_AAR);
            this.groupBoxData_AAR.Controls.Add(this.labelEnd_AAR);
            this.groupBoxData_AAR.Controls.Add(this.labelStart_AAR);
            this.groupBoxData_AAR.Location = new System.Drawing.Point(15, 368);
            this.groupBoxData_AAR.Name = "groupBoxData_AAR";
            this.groupBoxData_AAR.Size = new System.Drawing.Size(302, 70);
            this.groupBoxData_AAR.TabIndex = 2;
            this.groupBoxData_AAR.TabStop = false;
            this.groupBoxData_AAR.Text = "Ввод данных";
            // 
            // buttonHelp_AAR
            // 
            this.buttonHelp_AAR.BackColor = System.Drawing.Color.Teal;
            this.buttonHelp_AAR.Location = new System.Drawing.Point(323, 368);
            this.buttonHelp_AAR.Name = "buttonHelp_AAR";
            this.buttonHelp_AAR.Size = new System.Drawing.Size(98, 70);
            this.buttonHelp_AAR.TabIndex = 3;
            this.buttonHelp_AAR.Text = "Справка";
            this.buttonHelp_AAR.UseVisualStyleBackColor = false;
            this.buttonHelp_AAR.Click += new System.EventHandler(this.buttonHelp_AAR_Click);
            // 
            // buttonOutput_AAR
            // 
            this.buttonOutput_AAR.BackColor = System.Drawing.Color.Green;
            this.buttonOutput_AAR.Location = new System.Drawing.Point(427, 370);
            this.buttonOutput_AAR.Name = "buttonOutput_AAR";
            this.buttonOutput_AAR.Size = new System.Drawing.Size(145, 67);
            this.buttonOutput_AAR.TabIndex = 4;
            this.buttonOutput_AAR.Text = "Выполнить";
            this.buttonOutput_AAR.UseVisualStyleBackColor = false;
            this.buttonOutput_AAR.Click += new System.EventHandler(this.buttonOutput_AAR_Click);
            // 
            // labelStart_AAR
            // 
            this.labelStart_AAR.AutoSize = true;
            this.labelStart_AAR.Location = new System.Drawing.Point(6, 16);
            this.labelStart_AAR.Name = "labelStart_AAR";
            this.labelStart_AAR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_AAR.TabIndex = 0;
            this.labelStart_AAR.Text = "Старт шага:";
            // 
            // labelEnd_AAR
            // 
            this.labelEnd_AAR.AutoSize = true;
            this.labelEnd_AAR.Location = new System.Drawing.Point(166, 16);
            this.labelEnd_AAR.Name = "labelEnd_AAR";
            this.labelEnd_AAR.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_AAR.TabIndex = 1;
            this.labelEnd_AAR.Text = "Конец шага:";
            // 
            // textBoxStar_AAR
            // 
            this.textBoxStar_AAR.Location = new System.Drawing.Point(9, 44);
            this.textBoxStar_AAR.Name = "textBoxStar_AAR";
            this.textBoxStar_AAR.Size = new System.Drawing.Size(154, 20);
            this.textBoxStar_AAR.TabIndex = 2;
            // 
            // textBoxEnd_AAR
            // 
            this.textBoxEnd_AAR.Location = new System.Drawing.Point(169, 44);
            this.textBoxEnd_AAR.Name = "textBoxEnd_AAR";
            this.textBoxEnd_AAR.Size = new System.Drawing.Size(127, 20);
            this.textBoxEnd_AAR.TabIndex = 3;
            // 
            // labelResult_AAR
            // 
            this.labelResult_AAR.AutoSize = true;
            this.labelResult_AAR.Location = new System.Drawing.Point(14, 33);
            this.labelResult_AAR.Name = "labelResult_AAR";
            this.labelResult_AAR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAR.TabIndex = 0;
            this.labelResult_AAR.Text = "Результат:";
            // 
            // textBoxResult_AAR
            // 
            this.textBoxResult_AAR.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_AAR.Location = new System.Drawing.Point(17, 49);
            this.textBoxResult_AAR.Multiline = true;
            this.textBoxResult_AAR.Name = "textBoxResult_AAR";
            this.textBoxResult_AAR.ReadOnly = true;
            this.textBoxResult_AAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AAR.Size = new System.Drawing.Size(245, 373);
            this.textBoxResult_AAR.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.buttonOutput_AAR);
            this.Controls.Add(this.buttonHelp_AAR);
            this.Controls.Add(this.groupBoxData_AAR);
            this.Controls.Add(this.groupBoxResult_AAR);
            this.Controls.Add(this.groupBoxInfo_AAR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 2 | Аширбакиев А. Р.";
            this.groupBoxInfo_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.PerformLayout();
            this.groupBoxResult_AAR.ResumeLayout(false);
            this.groupBoxResult_AAR.PerformLayout();
            this.groupBoxData_AAR.ResumeLayout(false);
            this.groupBoxData_AAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_AAR;
        private System.Windows.Forms.TextBox textBoxInfo_AAR;
        private System.Windows.Forms.GroupBox groupBoxResult_AAR;
        private System.Windows.Forms.TextBox textBoxResult_AAR;
        private System.Windows.Forms.Label labelResult_AAR;
        private System.Windows.Forms.GroupBox groupBoxData_AAR;
        private System.Windows.Forms.TextBox textBoxEnd_AAR;
        private System.Windows.Forms.TextBox textBoxStar_AAR;
        private System.Windows.Forms.Label labelEnd_AAR;
        private System.Windows.Forms.Label labelStart_AAR;
        private System.Windows.Forms.Button buttonHelp_AAR;
        private System.Windows.Forms.Button buttonOutput_AAR;
    }
}

