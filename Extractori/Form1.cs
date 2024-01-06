using Extractori.toiminnot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extractori
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = $"Current output folder: {Toiminnot.getOutputPath()}";
            Toiminnot.OnUpdateProgressBar += UpdateProgressBar;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toiminnot.OpenFileDialog();
            refreshLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Toiminnot.files.RemoveAt(listaLoota.SelectedIndex);
            refreshLista();
        }

        private void refreshLista()
        {
            listaLoota.Items.Clear();
            foreach (string item in Toiminnot.files)
            {
                listaLoota.Items.Add(item);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Toiminnot.OpenOutputDialog();
            label2.Text = $"Current output folder: {Toiminnot.getOutputPath()}";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show
                ($"The selected files will be extracted to {Toiminnot.getOutputPath()}. This will overwrite any existing files. Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
                );
            if (result == DialogResult.Yes)
            {
                Toiminnot.ExtractFiles();
            }
        }

        private void UpdateProgressBar(int value, int maxValue)
        {
            if (progressBar1.InvokeRequired)
                {
                progressBar1.Invoke(new Action(() =>
                {
                    progressBar1.Value = value;
                    progressBar1.Maximum = maxValue;
                }));
                }
            else
            {
                progressBar1.Value = value;
                progressBar1.Maximum = maxValue;
            }
        }

        private void setDefaultOutputPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toiminnot.setOutputPath();
        }

        private void setDefaultInputPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toiminnot.setInputPath();
        }

    }
}
