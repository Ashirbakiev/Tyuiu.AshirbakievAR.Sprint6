
namespace Tyuiu.AshirbakievAR.Sprint6.Task7.V21
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
            this.panelHeader_AAR = new System.Windows.Forms.Panel();
            this.buttonHelp_AAR = new System.Windows.Forms.Button();
            this.buttonDone_AAR = new System.Windows.Forms.Button();
            this.buttonPush_AAR = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxInput_AAR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_AAR = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxOutput_AAR = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_AAR = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_AAR = new System.Windows.Forms.OpenFileDialog();
            this.buttonSave_AAR = new System.Windows.Forms.Button();
            this.saveFileDialogMatrix_AAR = new System.Windows.Forms.SaveFileDialog();
            this.panelHeader_AAR.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxInput_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AAR)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBoxOutput_AAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader_AAR
            // 
            this.panelHeader_AAR.Controls.Add(this.buttonHelp_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonSave_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonDone_AAR);
            this.panelHeader_AAR.Controls.Add(this.buttonPush_AAR);
            this.panelHeader_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader_AAR.Location = new System.Drawing.Point(0, 0);
            this.panelHeader_AAR.Name = "panelHeader_AAR";
            this.panelHeader_AAR.Size = new System.Drawing.Size(800, 86);
            this.panelHeader_AAR.TabIndex = 3;
            // 
            // buttonHelp_AAR
            // 
            this.buttonHelp_AAR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_AAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_AAR.Image")));
            this.buttonHelp_AAR.Location = new System.Drawing.Point(716, 12);
            this.buttonHelp_AAR.Name = "buttonHelp_AAR";
            this.buttonHelp_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonHelp_AAR.TabIndex = 1;
            this.buttonHelp_AAR.UseVisualStyleBackColor = true;
            this.buttonHelp_AAR.Click += new System.EventHandler(this.buttonHelp_AAR_Click);
            // 
            // buttonDone_AAR
            // 
            this.buttonDone_AAR.Enabled = false;
            this.buttonDone_AAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_AAR.Image")));
            this.buttonDone_AAR.Location = new System.Drawing.Point(84, 12);
            this.buttonDone_AAR.Name = "buttonDone_AAR";
            this.buttonDone_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonDone_AAR.TabIndex = 1;
            this.buttonDone_AAR.UseVisualStyleBackColor = true;
            this.buttonDone_AAR.Click += new System.EventHandler(this.buttonDone_AAR_Click);
            // 
            // buttonPush_AAR
            // 
            this.buttonPush_AAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonPush_AAR.Image")));
            this.buttonPush_AAR.Location = new System.Drawing.Point(3, 12);
            this.buttonPush_AAR.Name = "buttonPush_AAR";
            this.buttonPush_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonPush_AAR.TabIndex = 1;
            this.buttonPush_AAR.UseVisualStyleBackColor = true;
            this.buttonPush_AAR.Click += new System.EventHandler(this.buttonPush_AAR_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(524, 43);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxInput_AAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 278);
            this.panel2.TabIndex = 5;
            // 
            // groupBoxInput_AAR
            // 
            this.groupBoxInput_AAR.Controls.Add(this.dataGridViewInMatrix_AAR);
            this.groupBoxInput_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_AAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_AAR.Name = "groupBoxInput_AAR";
            this.groupBoxInput_AAR.Size = new System.Drawing.Size(369, 278);
            this.groupBoxInput_AAR.TabIndex = 2;
            this.groupBoxInput_AAR.TabStop = false;
            this.groupBoxInput_AAR.Text = "Ввод:";
            // 
            // dataGridViewInMatrix_AAR
            // 
            this.dataGridViewInMatrix_AAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_AAR.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInMatrix_AAR.Name = "dataGridViewInMatrix_AAR";
            this.dataGridViewInMatrix_AAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInMatrix_AAR.Size = new System.Drawing.Size(363, 259);
            this.dataGridViewInMatrix_AAR.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(369, 172);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 278);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxOutput_AAR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(379, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(421, 278);
            this.panel3.TabIndex = 7;
            // 
            // groupBoxOutput_AAR
            // 
            this.groupBoxOutput_AAR.Controls.Add(this.dataGridViewOutMatrix_AAR);
            this.groupBoxOutput_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_AAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_AAR.Name = "groupBoxOutput_AAR";
            this.groupBoxOutput_AAR.Size = new System.Drawing.Size(421, 278);
            this.groupBoxOutput_AAR.TabIndex = 3;
            this.groupBoxOutput_AAR.TabStop = false;
            this.groupBoxOutput_AAR.Text = "Вывод:";
            // 
            // dataGridViewOutMatrix_AAR
            // 
            this.dataGridViewOutMatrix_AAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_AAR.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutMatrix_AAR.Name = "dataGridViewOutMatrix_AAR";
            this.dataGridViewOutMatrix_AAR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutMatrix_AAR.Size = new System.Drawing.Size(415, 259);
            this.dataGridViewOutMatrix_AAR.TabIndex = 1;
            // 
            // openFileDialogTask_AAR
            // 
            this.openFileDialogTask_AAR.FileName = "openFileDialog1";
            // 
            // buttonSave_AAR
            // 
            this.buttonSave_AAR.Enabled = false;
            this.buttonSave_AAR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_AAR.Image")));
            this.buttonSave_AAR.Location = new System.Drawing.Point(165, 12);
            this.buttonSave_AAR.Name = "buttonSave_AAR";
            this.buttonSave_AAR.Size = new System.Drawing.Size(75, 68);
            this.buttonSave_AAR.TabIndex = 1;
            this.buttonSave_AAR.UseVisualStyleBackColor = true;
            this.buttonSave_AAR.Click += new System.EventHandler(this.buttonSave_AAR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader_AAR);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelHeader_AAR.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxInput_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_AAR)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBoxOutput_AAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_AAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader_AAR;
        private System.Windows.Forms.Button buttonHelp_AAR;
        private System.Windows.Forms.Button buttonDone_AAR;
        private System.Windows.Forms.Button buttonPush_AAR;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxInput_AAR;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_AAR;
        private System.Windows.Forms.GroupBox groupBoxOutput_AAR;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_AAR;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_AAR;
        private System.Windows.Forms.Button buttonSave_AAR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_AAR;
    }
}

