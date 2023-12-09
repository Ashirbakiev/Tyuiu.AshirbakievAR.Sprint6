using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AshirbakievAR.Sprint6.Task4.V17.Lib;
using System.IO;

namespace Tyuiu.AshirbakievAR.Sprint6.Task4.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonPush_AAR_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_AAR.Text);
                int stopStep = Convert.ToInt32(textBoxEnd_AAR.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                //this.chartFunction_AAG.Titles.Add("График функции");
                this.chartFunction_AAR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAR.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_AAR.Text = "";
                chartFunction_AAR.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {


                    this.chartFunction_AAR.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_AAR.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task4 выполнил студент группы СМАРТб,-23-1 Аширбакиев Алмаз Ринатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_AAR_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V17.txt";
                File.WriteAllText(path, textBoxResult_AAR.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
