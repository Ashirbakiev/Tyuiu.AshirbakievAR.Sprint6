using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.AshirbakievAR.Sprint6.Task7.V21.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task7.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_AAR.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
            saveFileDialogMatrix_AAR.Filter = "Значения, разделенные запятыми(* .csv)|*.csv|Все фалы(*.*)|*.*";
        }
        static string OpenFilePath;
        DataService ds = new DataService();

        private void buttonSave_AAR_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_AAR.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_AAR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_AAR.ShowDialog();
            string path = saveFileDialogMatrix_AAR.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutMatrix_AAR.RowCount;
            int columns = dataGridViewOutMatrix_AAR.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutMatrix_AAR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutMatrix_AAR.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(OpenFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutMatrix_AAR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            buttonSave_AAR.Enabled = true;
        }
        static int rows;
        static int columns;
        public static int[,] LoadFromFileDta(string FilePath)
        {
            string fileDta = File.ReadAllText(FilePath);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);

                }
            }
            return arrayValues;
        }

        private void buttonPush_AAR_Click(object sender, EventArgs e)
        {
            openFileDialogTask_AAR.ShowDialog();
            OpenFilePath = openFileDialogTask_AAR.FileName;

            int[,] arrayValues = LoadFromFileDta(OpenFilePath);
            dataGridViewInMatrix_AAR.ColumnCount = columns;
            dataGridViewInMatrix_AAR.RowCount = rows;
            dataGridViewOutMatrix_AAR.ColumnCount = columns;
            dataGridViewOutMatrix_AAR.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInMatrix_AAR.Columns[i].Width = 25;
                dataGridViewOutMatrix_AAR.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInMatrix_AAR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }


            }
            arrayValues = ds.GetMatrix(OpenFilePath);
            buttonDone_AAR.Enabled = true;
            buttonSave_AAR.Enabled = true;
        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
