
namespace Tyuiu.AshirbakievAR.Sprint6.Task4.V17
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelHeader_AAR = new System.Windows.Forms.Panel();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.buttonSave_AAR = new System.Windows.Forms.Button();
            this.buttonPush_AAR = new System.Windows.Forms.Button();
            this.groupBoxInput_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxStart_AAR = new System.Windows.Forms.TextBox();
            this.labelEnd_AAR = new System.Windows.Forms.Label();
            this.labelStart_AAR = new System.Windows.Forms.Label();
            this.groupBoxInfo_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_AAR = new System.Windows.Forms.TextBox();
            this.panelSection_AAR = new System.Windows.Forms.Panel();
            this.groupBoxOutput_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxResult_AAR = new System.Windows.Forms.TextBox();
            this.panelMain_AAR = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxEnd_AAR = new System.Windows.Forms.TextBox();
            this.chartFunction_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelHeader_AAR.SuspendLayout();
            this.groupBoxInput_AAR.SuspendLayout();
            this.groupBoxInfo_AAR.SuspendLayout();
            this.panelSection_AAR.SuspendLayout();
            this.groupBoxOutput_AAR.SuspendLayout();
            this.panelMain_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader_AAR
            // 
            this.panelHeader_AAR.Controls.Add(this.buttonHelp_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonSave_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonPush_AAR);
            this.panelHeader_AAR.Controls.Add(this.groupBoxInput_AAR);
            this.panelHeader_AAR.Controls.Add(this.groupBoxInfo_AAR);
            this.panelHeader_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader_AAR.Location = new System.Drawing.Point(0, 0);
            this.panelHeader_AAR.Name = "panelHeader_AAR";
            this.panelHeader_AAR.Size = new System.Drawing.Size(800, 86);
            this.panelHeader_AAR.TabIndex = 0;
            // 
            // buttonHelp_AAR
            // 
            this.buttonHelp_AAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAR.Location = new System.Drawing.Point(716, 12);
            this.buttonHelp_AAR.Name = "buttonHelp_AAR";
            this.buttonHelp_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonHelp_AAR.TabIndex = 1;
            this.buttonHelp_AAR.Text = "Справка";
            this.buttonHelp_AAR.UseVisualStyleBackColor = true;
            this.buttonHelp_AAR.Click += new System.EventHandler(this.buttonHelp_AAR_Click);
            // 
            // buttonSave_AAR
            // 
            this.buttonSave_AAR.Location = new System.Drawing.Point(635, 12);
            this.buttonSave_AAR.Name = "buttonSave_AAR";
            this.buttonSave_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonSave_AAR.TabIndex = 1;
            this.buttonSave_AAR.Text = "Сохранить";
            this.buttonSave_AAR.UseVisualStyleBackColor = true;
            this.buttonSave_AAR.Click += new System.EventHandler(this.buttonSave_AAR_Click);
            // 
            // buttonPush_AAR
            // 
            this.buttonPush_AAR.Location = new System.Drawing.Point(554, 12);
            this.buttonPush_AAR.Name = "buttonPush_AAR";
            this.buttonPush_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonPush_AAR.TabIndex = 1;
            this.buttonPush_AAR.Text = "Отправить";
            this.buttonPush_AAR.UseVisualStyleBackColor = true;
            this.buttonPush_AAR.Click += new System.EventHandler(this.buttonPush_AAR_Click);
            // 
            // groupBoxInput_AAR
            // 
            this.groupBoxInput_AAR.Controls.Add(this.textBoxEnd_AAR);
            this.groupBoxInput_AAR.Controls.Add(this.textBoxStart_AAR);
            this.groupBoxInput_AAR.Controls.Add(this.labelEnd_AAR);
            this.groupBoxInput_AAR.Controls.Add(this.labelStart_AAR);
            this.groupBoxInput_AAR.Location = new System.Drawing.Point(321, 12);
            this.groupBoxInput_AAR.Name = "groupBoxInput_AAR";
            this.groupBoxInput_AAR.Size = new System.Drawing.Size(227, 68);
            this.groupBoxInput_AAR.TabIndex = 0;
            this.groupBoxInput_AAR.TabStop = false;
            this.groupBoxInput_AAR.Text = "Ввод данных:";
            // 
            // textBoxStart_AAR
            // 
            this.textBoxStart_AAR.Location = new System.Drawing.Point(9, 42);
            this.textBoxStart_AAR.Name = "textBoxStart_AAR";
            this.textBoxStart_AAR.Size = new System.Drawing.Size(96, 20);
            this.textBoxStart_AAR.TabIndex = 3;
            // 
            // labelEnd_AAR
            // 
            this.labelEnd_AAR.AutoSize = true;
            this.labelEnd_AAR.Location = new System.Drawing.Point(108, 19);
            this.labelEnd_AAR.Name = "labelEnd_AAR";
            this.labelEnd_AAR.Size = new System.Drawing.Size(69, 13);
            this.labelEnd_AAR.TabIndex = 2;
            this.labelEnd_AAR.Text = "Конец шага:";
            // 
            // labelStart_AAR
            // 
            this.labelStart_AAR.AutoSize = true;
            this.labelStart_AAR.Location = new System.Drawing.Point(6, 19);
            this.labelStart_AAR.Name = "labelStart_AAR";
            this.labelStart_AAR.Size = new System.Drawing.Size(67, 13);
            this.labelStart_AAR.TabIndex = 1;
            this.labelStart_AAR.Text = "Старт шага:";
            // 
            // groupBoxInfo_AAR
            // 
            this.groupBoxInfo_AAR.Controls.Add(this.textBoxInfo_AAR);
            this.groupBoxInfo_AAR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_AAR.Name = "groupBoxInfo_AAR";
            this.groupBoxInfo_AAR.Size = new System.Drawing.Size(303, 68);
            this.groupBoxInfo_AAR.TabIndex = 0;
            this.groupBoxInfo_AAR.TabStop = false;
            this.groupBoxInfo_AAR.Text = "Условие:";
            // 
            // textBoxInfo_AAR
            // 
            this.textBoxInfo_AAR.Location = new System.Drawing.Point(6, 19);
            this.textBoxInfo_AAR.Multiline = true;
            this.textBoxInfo_AAR.Name = "textBoxInfo_AAR";
            this.textBoxInfo_AAR.ReadOnly = true;
            this.textBoxInfo_AAR.Size = new System.Drawing.Size(291, 43);
            this.textBoxInfo_AAR.TabIndex = 2;
            this.textBoxInfo_AAR.Text = resources.GetString("textBoxInfo_AAR.Text");
            // 
            // panelSection_AAR
            // 
            this.panelSection_AAR.Controls.Add(this.groupBoxOutput_AAR);
            this.panelSection_AAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSection_AAR.Location = new System.Drawing.Point(0, 86);
            this.panelSection_AAR.Name = "panelSection_AAR";
            this.panelSection_AAR.Padding = new System.Windows.Forms.Padding(5);
            this.panelSection_AAR.Size = new System.Drawing.Size(223, 364);
            this.panelSection_AAR.TabIndex = 0;
            // 
            // groupBoxOutput_AAR
            // 
            this.groupBoxOutput_AAR.Controls.Add(this.textBoxResult_AAR);
            this.groupBoxOutput_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_AAR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutput_AAR.Name = "groupBoxOutput_AAR";
            this.groupBoxOutput_AAR.Size = new System.Drawing.Size(213, 354);
            this.groupBoxOutput_AAR.TabIndex = 0;
            this.groupBoxOutput_AAR.TabStop = false;
            this.groupBoxOutput_AAR.Text = "Вывод:";
            // 
            // textBoxResult_AAR
            // 
            this.textBoxResult_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_AAR.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult_AAR.Multiline = true;
            this.textBoxResult_AAR.Name = "textBoxResult_AAR";
            this.textBoxResult_AAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_AAR.Size = new System.Drawing.Size(207, 335);
            this.textBoxResult_AAR.TabIndex = 0;
            // 
            // panelMain_AAR
            // 
            this.panelMain_AAR.Controls.Add(this.chartFunction_AAR);
            this.panelMain_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain_AAR.Location = new System.Drawing.Point(223, 86);
            this.panelMain_AAR.Name = "panelMain_AAR";
            this.panelMain_AAR.Size = new System.Drawing.Size(577, 364);
            this.panelMain_AAR.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(223, 86);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 364);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // textBoxEnd_AAR
            // 
            this.textBoxEnd_AAR.Location = new System.Drawing.Point(111, 42);
            this.textBoxEnd_AAR.Name = "textBoxEnd_AAR";
            this.textBoxEnd_AAR.Size = new System.Drawing.Size(96, 20);
            this.textBoxEnd_AAR.TabIndex = 3;
            // 
            // chartFunction_AAR
            // 
            chartArea5.AxisX.Title = "ось X";
            chartArea5.AxisY.Title = "ось Y";
            chartArea5.Name = "ChartArea1";
            this.chartFunction_AAR.ChartAreas.Add(chartArea5);
            this.chartFunction_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartFunction_AAR.Legends.Add(legend5);
            this.chartFunction_AAR.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_AAR.Name = "chartFunction_AAR";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_AAR.Series.Add(series5);
            this.chartFunction_AAR.Size = new System.Drawing.Size(577, 364);
            this.chartFunction_AAR.TabIndex = 3;
            this.chartFunction_AAR.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "График функции";
            this.chartFunction_AAR.Titles.Add(title5);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelMain_AAR);
            this.Controls.Add(this.panelSection_AAR);
            this.Controls.Add(this.panelHeader_AAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 17 | Аширбакиев А. Р.";
            this.panelHeader_AAR.ResumeLayout(false);
            this.groupBoxInput_AAR.ResumeLayout(false);
            this.groupBoxInput_AAR.PerformLayout();
            this.groupBoxInfo_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.PerformLayout();
            this.panelSection_AAR.ResumeLayout(false);
            this.groupBoxOutput_AAR.ResumeLayout(false);
            this.groupBoxOutput_AAR.PerformLayout();
            this.panelMain_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_AAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader_AAR;
        private System.Windows.Forms.Panel panelSection_AAR;
        private System.Windows.Forms.GroupBox groupBoxOutput_AAR;
        private System.Windows.Forms.TextBox textBoxResult_AAR;
        private System.Windows.Forms.Panel panelMain_AAR;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button buttonHelp_AAR;
        private System.Windows.Forms.Button buttonSave_AAR;
        private System.Windows.Forms.Button buttonPush_AAR;
        private System.Windows.Forms.GroupBox groupBoxInput_AAR;
        private System.Windows.Forms.GroupBox groupBoxInfo_AAR;
        private System.Windows.Forms.TextBox textBoxInfo_AAR;
        private System.Windows.Forms.Label labelStart_AAR;
        private System.Windows.Forms.Label labelEnd_AAR;
        private System.Windows.Forms.TextBox textBoxStart_AAR;
        private System.Windows.Forms.TextBox textBoxEnd_AAR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAR;
    }
}

