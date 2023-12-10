
namespace Tyuiu.AshirbakievAR.Sprint6.Task5.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelHeader_AAR = new System.Windows.Forms.Panel();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.buttonSave_AAR = new System.Windows.Forms.Button();
            this.buttonPush_AAR = new System.Windows.Forms.Button();
            this.groupBoxInfo_AAR = new System.Windows.Forms.GroupBox();
            this.textBoxInfo_AAR = new System.Windows.Forms.TextBox();
            this.panelSection_AAR = new System.Windows.Forms.Panel();
            this.groupBoxOutput_AAR = new System.Windows.Forms.GroupBox();
            this.splitter_AAR = new System.Windows.Forms.Splitter();
            this.panelMain_AAR = new System.Windows.Forms.Panel();
            this.chartResult_AAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_AAR = new System.Windows.Forms.DataGridView();
            this.panelHeader_AAR.SuspendLayout();
            this.groupBoxInfo_AAR.SuspendLayout();
            this.panelSection_AAR.SuspendLayout();
            this.groupBoxOutput_AAR.SuspendLayout();
            this.panelMain_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader_AAR
            // 
            this.panelHeader_AAR.Controls.Add(this.buttonHelp_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonSave_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonPush_AAR);
            this.panelHeader_AAR.Controls.Add(this.groupBoxInfo_AAR);
            this.panelHeader_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader_AAR.Location = new System.Drawing.Point(0, 0);
            this.panelHeader_AAR.Name = "panelHeader_AAR";
            this.panelHeader_AAR.Size = new System.Drawing.Size(800, 86);
            this.panelHeader_AAR.TabIndex = 1;
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
            this.buttonSave_AAR.Text = "Открыть файл";
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
            // groupBoxInfo_AAR
            // 
            this.groupBoxInfo_AAR.Controls.Add(this.textBoxInfo_AAR);
            this.groupBoxInfo_AAR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInfo_AAR.Name = "groupBoxInfo_AAR";
            this.groupBoxInfo_AAR.Size = new System.Drawing.Size(536, 68);
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
            this.textBoxInfo_AAR.Size = new System.Drawing.Size(524, 43);
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
            this.panelSection_AAR.TabIndex = 2;
            // 
            // groupBoxOutput_AAR
            // 
            this.groupBoxOutput_AAR.Controls.Add(this.dataGridViewResult_AAR);
            this.groupBoxOutput_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_AAR.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutput_AAR.Name = "groupBoxOutput_AAR";
            this.groupBoxOutput_AAR.Size = new System.Drawing.Size(213, 354);
            this.groupBoxOutput_AAR.TabIndex = 0;
            this.groupBoxOutput_AAR.TabStop = false;
            this.groupBoxOutput_AAR.Text = "Вывод:";
            // 
            // splitter_AAR
            // 
            this.splitter_AAR.Location = new System.Drawing.Point(223, 86);
            this.splitter_AAR.Name = "splitter_AAR";
            this.splitter_AAR.Size = new System.Drawing.Size(3, 364);
            this.splitter_AAR.TabIndex = 0;
            this.splitter_AAR.TabStop = false;
            // 
            // panelMain_AAR
            // 
            this.panelMain_AAR.Controls.Add(this.chartResult_AAR);
            this.panelMain_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain_AAR.Location = new System.Drawing.Point(226, 86);
            this.panelMain_AAR.Name = "panelMain_AAR";
            this.panelMain_AAR.Size = new System.Drawing.Size(574, 364);
            this.panelMain_AAR.TabIndex = 3;
            // 
            // chartResult_AAR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_AAR.ChartAreas.Add(chartArea1);
            this.chartResult_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_AAR.Legends.Add(legend1);
            this.chartResult_AAR.Location = new System.Drawing.Point(0, 0);
            this.chartResult_AAR.Name = "chartResult_AAR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_AAR.Series.Add(series1);
            this.chartResult_AAR.Size = new System.Drawing.Size(574, 364);
            this.chartResult_AAR.TabIndex = 0;
            this.chartResult_AAR.Text = "chart1";
            // 
            // dataGridViewResult_AAR
            // 
            this.dataGridViewResult_AAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_AAR.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult_AAR.Name = "dataGridViewResult_AAR";
            this.dataGridViewResult_AAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_AAR.Size = new System.Drawing.Size(207, 335);
            this.dataGridViewResult_AAR.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain_AAR);
            this.Controls.Add(this.splitter_AAR);
            this.Controls.Add(this.panelSection_AAR);
            this.Controls.Add(this.panelHeader_AAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 12 | Аширбакиев А. Р.";
            this.panelHeader_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.ResumeLayout(false);
            this.groupBoxInfo_AAR.PerformLayout();
            this.panelSection_AAR.ResumeLayout(false);
            this.groupBoxOutput_AAR.ResumeLayout(false);
            this.panelMain_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_AAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader_AAR;
        private System.Windows.Forms.Button buttonHelp_AAR;
        private System.Windows.Forms.Button buttonSave_AAR;
        private System.Windows.Forms.Button buttonPush_AAR;
        private System.Windows.Forms.GroupBox groupBoxInfo_AAR;
        private System.Windows.Forms.TextBox textBoxInfo_AAR;
        private System.Windows.Forms.Panel panelSection_AAR;
        private System.Windows.Forms.GroupBox groupBoxOutput_AAR;
        private System.Windows.Forms.Splitter splitter_AAR;
        private System.Windows.Forms.Panel panelMain_AAR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAR;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAR;
    }
}

