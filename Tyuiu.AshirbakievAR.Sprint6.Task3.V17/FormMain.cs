using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AshirbakievAR.Sprint6.Task3.V17.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { 22, 32, -16, 24, 27 }, { 3, -20, 24, -20, 25 }, { 21, 17, -8, -19, 17 }, { 8, 22, 28, 27, 19 }, { 11, 20, 12, 27, 29 } };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewArrayBefore_AAR.ColumnCount = columns;
            dataGridViewArrayBefore_AAR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewArrayBefore_AAR.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewArrayBefore_AAR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task3 выполнил студент группы СМАРТб,-23-1 Аширбакиев Алмаз Ринатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPush_AAR_Click(object sender, EventArgs e)
        {
            int[,] matr = ds.Calculate(matrix);
            int rows = matr.GetUpperBound(0) + 1;
            int columns = matr.Length / rows;

            dataGridViewArrayResult_AAR.ColumnCount = columns;
            dataGridViewArrayResult_AAR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewArrayResult_AAR.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewArrayResult_AAR.Rows[i].Cells[j].Value = Convert.ToString(matr[i, j]);
                }
            }
        }
    }
}
