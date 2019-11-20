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

namespace Tema4_Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Visor de imagenes";
        }

        private void BtnFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Imágenes";
            sfd.InitialDirectory = Environment.GetEnvironmentVariable("userprofile") + "\\Desktop\\fotos";
            sfd.ShowDialog();
            StreamWriter s = new StreamWriter(sfd.FileName);
            
        }
    }
}
