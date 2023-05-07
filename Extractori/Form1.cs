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
        public String defaultPath = "G:\\";
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toiminnot.AvaaFileDialog();
            refreshLista();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Toiminnot.fileet.RemoveAt(listaLoota.SelectedIndex);
            Console.WriteLine(listaLoota.SelectedIndex.ToString());
            refreshLista();
        }

        private void refreshLista()
        {
            listaLoota.Items.Clear();
            foreach (string item in Toiminnot.fileet)
            {
                listaLoota.Items.Add(item);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Toiminnot.AvaaOutputDialog();
            label2.Text = $"Current output folder: {Toiminnot.outputPath}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show
                ($"The selected files will be extracted to {Toiminnot.outputPath}. This will overwrite any existing data folders and/or files. Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation
                );
            if (result == DialogResult.Yes)
            {
                Toiminnot.PuraTiedostot();
                progressBar1.Value = 0;
                progressBar1.Maximum = 100;
                progressBar1.Minimum = 0;
                progressBar1.Value = 100;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
