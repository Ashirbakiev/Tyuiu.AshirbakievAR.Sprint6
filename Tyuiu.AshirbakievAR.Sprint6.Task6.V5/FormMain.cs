using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AshirbakievAR.Sprint6.Task6.V5.Lib;
using System.IO;

namespace Tyuiu.AshirbakievAR.Sprint6.Task6.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonPush_AAR_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxResult_AAR   .Text = File.ReadAllText(openFilePath);
            groupBoxInput_AAR.Text = groupBoxInput_AAR.Text + " " + openFileDialogTask.FileName;
            buttonDone_AAR.Enabled = true;
        }

        private void buttonHelp_AAR_Click(object sender, EventArgs e)
        {
            FormAbout_AAR formAbout = new FormAbout_AAR();
            formAbout.ShowDialog();
        }

        private void buttonDone_AAR_Click(object sender, EventArgs e)
        {
            textBoxResultAfter_AAR.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
