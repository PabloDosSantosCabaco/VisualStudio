using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T4_E7
{
    public partial class Form1 : Form
    {
        bool fileSaved = false;
        public Form1()
        {
            InitializeComponent();
        }
        public void newDocument()
        {
            if (fileSaved)
            {
                txtContent.Clear();
            }else if (txtContent.Text.Length > 0 && !fileSaved)
            {
                switch(MessageBox.Show("¿Quieres guardar el documento?",
                    "Guardar archivo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        saveFile();
                        txtContent.Clear();
                        break;
                    case DialogResult.No:
                        txtContent.Clear();
                        break;
                }
            }
        }
        public void saveFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName,true))
                {
                    sw.WriteLine(txtContent.Text);
                    fileSaved = true;
                }
            }
        }
        public void openFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using(StreamReader sr = new StreamReader(ofd.FileName)){
                    txtContent.Text = sr.ReadToEnd();
                    fileSaved = true;
                }
            }
        }
        private void NuevoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDocument();
        }
        private void IconNew_Click(object sender, EventArgs e)
        {
            newDocument();
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void TxtContent_TextChanged(object sender, EventArgs e)
        {
            fileSaved = false;
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
