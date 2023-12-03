using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AshirbakievAR.Sprint6.Task1.V2.Lib;

namespace Tyuiu.AshirbakievAR.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonOutput_AAR_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStar_AAR.Text);
                int stopstep = Convert.ToInt32(textBoxEnd_AAR.Text);
                int len = ds.GetMassFunction(startstep, stopstep).Length;
                string str;
                double[] func = new double[len];
                func = ds.GetMassFunction(startstep, stopstep);
                textBoxResult_AAR.Text = "";
                textBoxResult_AAR.AppendText("+---------------------------- +" + Environment.NewLine);
                textBoxResult_AAR.AppendText("|    x     |     f(x)    |" + Environment.NewLine);
                textBoxResult_AAR.AppendText("+-----------------------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0, 6:d}    |  {1, 8:f2}    |", startstep, func[i]);
                    textBoxResult_AAR.AppendText(str + Environment.NewLine);
                    startstep++;
                }
                textBoxResult_AAR.AppendText("+----------------------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-23-1 Аширбакиев Алмаз Ринатович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
