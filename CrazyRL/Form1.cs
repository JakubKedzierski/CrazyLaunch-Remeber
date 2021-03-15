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

namespace CrazyRL
{
    public partial class Form1 : Form
    {

        private APIParser parser = new APIParser();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            progressBar1.Visible = true;
            buttonUpFromNet.Enabled = false;
 
            parser.downloadAPI();
            progressBar1.Value = 100;
            label1.Text = "Pobieranie zakończone";

            buttonUpFromNet.Enabled = true;
        }

        public void barState(int val)
        {
            if(val >= 0 & val <= 100) progressBar1.Value = val;
        }

        private void buttonUpFromFile_Click(object sender, EventArgs e)
        {

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {

        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if(!File.Exists("dane_lotow.txt"))
            {
                label1.Visible = true;
                label1.Text = "Brak danych do wyeksportowania!";
                return;
            }

            string storedFile = File.ReadAllText("dane_lotow.txt");

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                
                writer.WriteLine(storedFile);
                writer.Close();
                
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            label1.Visible = true;
            label1.Text = "Zapisano!";
        }
    }
}
