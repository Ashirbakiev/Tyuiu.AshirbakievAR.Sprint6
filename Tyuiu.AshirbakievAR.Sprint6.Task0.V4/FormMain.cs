using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AshirbakievAR.Sprint6.Task0.V4.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task0.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputX_AAR.Text = ds.Calculate(Convert.ToInt32(textBoxInputX.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

        private void textBoxInputX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТб-23-1 Аширбакиев Алмаз Ринатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
