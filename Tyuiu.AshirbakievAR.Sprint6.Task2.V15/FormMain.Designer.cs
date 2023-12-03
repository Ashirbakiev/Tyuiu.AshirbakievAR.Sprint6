
namespace Tyuiu.AshirbakievAR.Sprint6.Task2.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInfo_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_AAR = new System.Windows.Forms.TextBox();
            this.groupBoxData_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxEnd_AAR = new System.Windows.Forms.TextBox();
            this.textBoxStar_AAR = new System.Windows.Forms.TextBox();
            this.labelEnd_AAR = new System.Windows.Forms.Label();
            this.labelStart_AAR = new System.Windows.Forms.Label();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.buttonOutput_AAR = new System.Windows.Forms.Button();
            this.labelResult_AAR = new System.Windows.Forms.Label();
            this.groupBoxResult_AAR = new System.Windows.Forms.GroupBox();
            this.dataGridFunction_AAR = new System.Windows.Forms.DataGridView();
            this.ColumnX_AAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX_AAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxInfo_AAR.SuspendLayout();
            this.groupBoxData_AAR.SuspendLayout();
            this.groupBoxResult_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunction_AAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInfo_AAR
            // 
            this.groupBoxInfo_AAR.Controls.Add(this.textBoxInfo_AAR);
            this.groupBoxInfo_AAR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_AAR.Name = "groupBoxInfo_AAR";
            this.groupBoxInfo_AAR.Size = new System.Drawing.Size(557, 346);
            this.groupBoxInfo_AAR.TabIndex = 1;
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
            this.textBoxInfo_AAR.Text = "Протабулировать функцию (2SIN(X))/(3X+1,2)+COS(X)-7X*2 на заданном диапазоне.Резу" +
    "льтат вывести в таблице.";
            // 
            // groupBoxData_AAR
            // 
            this.groupBoxData_AAR.Controls.Add(this.textBoxEnd_AAR);
            this.groupBoxData_AAR.Controls.Add(this.textBoxStar_AAR);
            this.groupBoxData_AAR.Controls.Add(this.labelEnd_AAR);
            this.groupBoxData_AAR.Controls.Add(this.labelStart_AAR);
            this.groupBoxData_AAR.Location = new System.Drawing.Point(12, 368);
            this.groupBoxData_AAR.Name = "groupBoxData_AAR";
            this.groupBoxData_AAR.Size = new System.Drawing.Size(302, 70);
            this.groupBoxData_AAR.TabIndex = 3;
            this.groupBoxData_AAR.TabStop = false;
            this.groupBoxData_AAR.Text = "Ввод данных";
            // 
            // textBoxEnd_AAR
            // 
            this.textBoxEnd_AAR.Location = new System.Drawing.Point(169, 44);
            this.textBoxEnd_AAR.Name = "textBoxEnd_AAR";
            this.textBoxEnd_AAR.Size = new System.Drawing.Size(127, 20);
            this.textBoxEnd_AAR.TabIndex = 3;
            // 
            // textBoxStar_AAR
            // 
            this.textBoxStar_AAR.Location = new System.Drawing.Point(9, 44);
            this.textBoxStar_AAR.Name = "textBoxStar_AAR";
            this.textBoxStar_AAR.Size = new System.Drawing.Size(154, 20);
            this.textBoxStar_AAR.TabIndex = 2;
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
            // labelStart_AAR
            // 
            this.labelStart_AAR.AutoSize = true;
            this.labelStart_AAR.Location = new System.Drawing.Point(6, 16);
            this.labelStart_AAR.Name = "labelStart_AAR";
            this.labelStart_AAR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_AAR.TabIndex = 0;
            this.labelStart_AAR.Text = "Старт шага:";
            // 
            // buttonHelp_AAR
            // 
            this.buttonHelp_AAR.BackColor = System.Drawing.Color.Teal;
            this.buttonHelp_AAR.Location = new System.Drawing.Point(320, 368);
            this.buttonHelp_AAR.Name = "buttonHelp_AAR";
            this.buttonHelp_AAR.Size = new System.Drawing.Size(98, 70);
            this.buttonHelp_AAR.TabIndex = 4;
            this.buttonHelp_AAR.Text = "Справка";
            this.buttonHelp_AAR.UseVisualStyleBackColor = false;
            this.buttonHelp_AAR.Click += new System.EventHandler(this.buttonHelp_AAR_Click);
            // 
            // buttonOutput_AAR
            // 
            this.buttonOutput_AAR.BackColor = System.Drawing.Color.Green;
            this.buttonOutput_AAR.Location = new System.Drawing.Point(424, 370);
            this.buttonOutput_AAR.Name = "buttonOutput_AAR";
            this.buttonOutput_AAR.Size = new System.Drawing.Size(145, 67);
            this.buttonOutput_AAR.TabIndex = 5;
            this.buttonOutput_AAR.Text = "Выполнить";
            this.buttonOutput_AAR.UseVisualStyleBackColor = false;
            this.buttonOutput_AAR.Click += new System.EventHandler(this.buttonOutput_AAR_Click);
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
            // groupBoxResult_AAR
            // 
            this.groupBoxResult_AAR.Controls.Add(this.chartFunction_AAR);
            this.groupBoxResult_AAR.Controls.Add(this.dataGridFunction_AAR);
            this.groupBoxResult_AAR.Controls.Add(this.labelResult_AAR);
            this.groupBoxResult_AAR.Location = new System.Drawing.Point(575, 16);
            this.groupBoxResult_AAR.Name = "groupBoxResult_AAR";
            this.groupBoxResult_AAR.Size = new System.Drawing.Size(619, 422);
            this.groupBoxResult_AAR.TabIndex = 6;
            this.groupBoxResult_AAR.TabStop = false;
            this.groupBoxResult_AAR.Text = "Вывод данных";
            // 
            // dataGridFunction_AAR
            // 
            this.dataGridFunction_AAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFunction_AAR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_AAR,
            this.ColumnFX_AAR});
            this.dataGridFunction_AAR.Location = new System.Drawing.Point(17, 63);
            this.dataGridFunction_AAR.Name = "dataGridFunction_AAR";
            this.dataGridFunction_AAR.RowHeadersVisible = false;
            this.dataGridFunction_AAR.Size = new System.Drawing.Size(134, 353);
            this.dataGridFunction_AAR.TabIndex = 1;
            // 
            // ColumnX_AAR
            // 
            this.ColumnX_AAR.HeaderText = "X";
            this.ColumnX_AAR.Name = "ColumnX_AAR";
            this.ColumnX_AAR.Width = 50;
            // 
            // ColumnFX_AAR
            // 
            this.ColumnFX_AAR.HeaderText = "F(X)";
            this.ColumnFX_AAR.Name = "ColumnFX_AAR";
            this.ColumnFX_AAR.Width = 50;
            // 
            // chartFunction_AAR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_AAR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_AAR.Legends.Add(legend2);
            this.chartFunction_AAR.Location = new System.Drawing.Point(157, 63);
            this.chartFunction_AAR.Name = "chartFunction_AAR";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_AAR.Series.Add(series2);
            this.chartFunction_AAR.Size = new System.Drawing.Size(461, 352);
            this.chartFunction_AAR.TabIndex = 2;
            this.chartFunction_AAR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 450);
            this.Controls.Add(this.groupBoxResult_AAR);
            this.Controls.Add(this.buttonOutput_AAR);
            this.Controls.Add(this.buttonHelp_AAR);
            this.Controls.Add(this.groupBoxData_AAR);
            this.Controls.Add(this.groupBoxInfo_AAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 15 | Аширбакиев А. Р.";
            this.groupBoxInfo_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.PerformLayout();
            this.groupBoxData_AAR.ResumeLayout(false);
            this.groupBoxData_AAR.PerformLayout();
            this.groupBoxResult_AAR.ResumeLayout(false);
            this.groupBoxResult_AAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunction_AAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInfo_AAR;
        private System.Windows.Forms.TextBox textBoxInfo_AAR;
        private System.Windows.Forms.GroupBox groupBoxData_AAR;
        private System.Windows.Forms.TextBox textBoxEnd_AAR;
        private System.Windows.Forms.TextBox textBoxStar_AAR;
        private System.Windows.Forms.Label labelEnd_AAR;
        private System.Windows.Forms.Label labelStart_AAR;
        private System.Windows.Forms.Button buttonHelp_AAR;
        private System.Windows.Forms.Button buttonOutput_AAR;
        private System.Windows.Forms.Label labelResult_AAR;
        private System.Windows.Forms.GroupBox groupBoxResult_AAR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAR;
        private System.Windows.Forms.DataGridView dataGridFunction_AAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_AAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX_AAR;
    }
}

