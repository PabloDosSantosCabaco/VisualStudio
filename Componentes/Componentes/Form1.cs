using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class Form1 : Form
    {
        string rutaIcono = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\iconos\\arcade_ahri.ico";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        private void salir()
        {
            //Pedir confirmación
            this.Close();
        }
    }
}
