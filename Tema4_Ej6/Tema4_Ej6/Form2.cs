using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ej6
{
    public partial class Form2 : Form
    {
        string codigo = "1111";
        int intentos = 3;
        public Form2(Form1 f)
        {
            InitializeComponent();
        }

        private void BtnPIN_Click(object sender, EventArgs e)
        {
            if (intentos <= 0)
            {
                lblError.Text = $"Móvil bloqueado.{Environment.NewLine}Número de intentos superado.";
                return;
            }
            if (!txtPIN.Text.Trim().Equals(codigo))
            {
                intentos--;
                lblError.Text = $"PIN incorrecto. Le quedan {intentos} intentos";
            }
            else
            {
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
