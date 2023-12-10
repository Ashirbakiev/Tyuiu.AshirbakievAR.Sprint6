using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AshirbakievAR.Sprint6.Task5.V12.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task5.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutFileTask5V12.txt";
        private void buttonPush_AAR_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewResult_AAR.ColumnCount = 2;
                dataGridViewResult_AAR.Columns[0].Width = 20;
                dataGridViewResult_AAR.Columns[1].Width = 50;

                this.chartResult_AAR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_AAR.ChartAreas[0].AxisY.Title = "Ось Y";

                chartResult_AAR.Series[0].Points.Clear();
                dataGridViewResult_AAR.Rows.Clear();
                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewResult_AAR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartResult_AAR.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка чтения файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_AAR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task5 выполнил студент группы СМАРТб,-23-1 Аширбакиев Алмаз Ринатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
