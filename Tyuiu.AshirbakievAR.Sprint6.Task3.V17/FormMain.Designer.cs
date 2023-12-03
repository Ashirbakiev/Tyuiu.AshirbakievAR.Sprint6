
namespace Tyuiu.AshirbakievAR.Sprint6.Task3.V17
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
            this.dataGridViewArrayBefore_AAR = new System.Windows.Forms.DataGridView();
            this.textBoxInfo_AAR = new System.Windows.Forms.TextBox();
            this.groupBoxResult_AAR = new System.Windows.Forms.GroupBox();
            this.labelResult_AAR = new System.Windows.Forms.Label();
            this.buttonPush_AAR = new System.Windows.Forms.Button();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.dataGridViewArrayResult_AAR = new System.Windows.Forms.DataGridView();
            this.groupBoxInfo_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayBefore_AAR)).BeginInit();
            this.groupBoxResult_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayResult_AAR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_AAR
            // 
            this.groupBoxInfo_AAR.Controls.Add(this.dataGridViewArrayBefore_AAR);
            this.groupBoxInfo_AAR.Controls.Add(this.textBoxInfo_AAR);
            this.groupBoxInfo_AAR.Location = new System.Drawing.Point(29, 23);
            this.groupBoxInfo_AAR.Name = "groupBoxInfo_AAR";
            this.groupBoxInfo_AAR.Size = new System.Drawing.Size(544, 277);
            this.groupBoxInfo_AAR.TabIndex = 0;
            this.groupBoxInfo_AAR.TabStop = false;
            this.groupBoxInfo_AAR.Text = "Условие";
            // 
            // dataGridViewArrayBefore_AAR
            // 
            this.dataGridViewArrayBefore_AAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrayBefore_AAR.ColumnHeadersVisible = false;
            this.dataGridViewArrayBefore_AAR.Location = new System.Drawing.Point(299, 18);
            this.dataGridViewArrayBefore_AAR.Name = "dataGridViewArrayBefore_AAR";
            this.dataGridViewArrayBefore_AAR.RowHeadersVisible = false;
            this.dataGridViewArrayBefore_AAR.Size = new System.Drawing.Size(235, 246);
            this.dataGridViewArrayBefore_AAR.TabIndex = 18;
            // 
            // textBoxInfo_AAR
            // 
            this.textBoxInfo_AAR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_AAR.Location = new System.Drawing.Point(6, 19);
            this.textBoxInfo_AAR.Multiline = true;
            this.textBoxInfo_AAR.Name = "textBoxInfo_AAR";
            this.textBoxInfo_AAR.ReadOnly = true;
            this.textBoxInfo_AAR.Size = new System.Drawing.Size(290, 194);
            this.textBoxInfo_AAR.TabIndex = 17;
            this.textBoxInfo_AAR.Text = "Дан массив 5 на 5 элементов.\r\n22  32 -16  24  27\r\n\r\n  3 -20  24 -20  25\r\n\r\n 21  1" +
    "7  -8 -19  17\r\n\r\n  8  22  28  27  19\r\n\r\n 11  20  12  27  29\r\nВыполнить сортировк" +
    "у по возрастанию в четвертом столбце.";
            // 
            // groupBoxResult_AAR
            // 
            this.groupBoxResult_AAR.Controls.Add(this.dataGridViewArrayResult_AAR);
            this.groupBoxResult_AAR.Controls.Add(this.labelResult_AAR);
            this.groupBoxResult_AAR.Location = new System.Drawing.Point(595, 23);
            this.groupBoxResult_AAR.Name = "groupBoxResult_AAR";
            this.groupBoxResult_AAR.Size = new System.Drawing.Size(238, 237);
            this.groupBoxResult_AAR.TabIndex = 1;
            this.groupBoxResult_AAR.TabStop = false;
            this.groupBoxResult_AAR.Text = "Вывод Данных";
            // 
            // labelResult_AAR
            // 
            this.labelResult_AAR.AutoSize = true;
            this.labelResult_AAR.Location = new System.Drawing.Point(13, 22);
            this.labelResult_AAR.Name = "labelResult_AAR";
            this.labelResult_AAR.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAR.TabIndex = 0;
            this.labelResult_AAR.Text = "Результат:";
            // 
            // buttonPush_AAR
            // 
            this.buttonPush_AAR.Location = new System.Drawing.Point(730, 266);
            this.buttonPush_AAR.Name = "buttonPush_AAR";
            this.buttonPush_AAR.Size = new System.Drawing.Size(103, 34);
            this.buttonPush_AAR.TabIndex = 2;
            this.buttonPush_AAR.Text = "button1";
            this.buttonPush_AAR.UseVisualStyleBackColor = true;
            this.buttonPush_AAR.Click += new System.EventHandler(this.buttonPush_AAR_Click);
            // 
            // buttonHelp_AAR
            // 
            this.buttonHelp_AAR.Location = new System.Drawing.Point(595, 266);
            this.buttonHelp_AAR.Name = "buttonHelp_AAR";
            this.buttonHelp_AAR.Size = new System.Drawing.Size(32, 34);
            this.buttonHelp_AAR.TabIndex = 3;
            this.buttonHelp_AAR.Text = "?";
            this.buttonHelp_AAR.UseVisualStyleBackColor = true;
            this.buttonHelp_AAR.Click += new System.EventHandler(this.buttonHelp_AAR_Click);
            // 
            // dataGridViewArrayResult_AAR
            // 
            this.dataGridViewArrayResult_AAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrayResult_AAR.ColumnHeadersVisible = false;
            this.dataGridViewArrayResult_AAR.Location = new System.Drawing.Point(16, 38);
            this.dataGridViewArrayResult_AAR.Name = "dataGridViewArrayResult_AAR";
            this.dataGridViewArrayResult_AAR.RowHeadersVisible = false;
            this.dataGridViewArrayResult_AAR.Size = new System.Drawing.Size(202, 193);
            this.dataGridViewArrayResult_AAR.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 323);
            this.Controls.Add(this.buttonHelp_AAR);
            this.Controls.Add(this.buttonPush_AAR);
            this.Controls.Add(this.groupBoxResult_AAR);
            this.Controls.Add(this.groupBoxInfo_AAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 17 | Аширбакиев А. Р.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInfo_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayBefore_AAR)).EndInit();
            this.groupBoxResult_AAR.ResumeLayout(false);
            this.groupBoxResult_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayResult_AAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_AAR;
        private System.Windows.Forms.TextBox textBoxInfo_AAR;
        private System.Windows.Forms.GroupBox groupBoxResult_AAR;
        private System.Windows.Forms.Label labelResult_AAR;
        private System.Windows.Forms.Button buttonPush_AAR;
        private System.Windows.Forms.Button buttonHelp_AAR;
        private System.Windows.Forms.DataGridView dataGridViewArrayBefore_AAR;
        private System.Windows.Forms.DataGridView dataGridViewArrayResult_AAR;
    }
}

