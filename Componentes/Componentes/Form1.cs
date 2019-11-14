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
    public partial class form1 : Form
    {
        string rutaIcono = Environment.GetEnvironmentVariable("USERPROFILE") + "\\Desktop\\iconos\\arcade_ahri.ico";
        public form1()
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
            if (MessageBox.Show("¿Desea salir del formulario?", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            try
            {
                n1 = Convert.ToInt32(txtColor1.Text);
                n2 = Convert.ToInt32(txtColor2.Text);
                n3 = Convert.ToInt32(txtColor3.Text);
                if (numValido(n1) && numValido(n2) && numValido(n3)){
                    this.ForeColor = new Color();
                }
            }
            catch (FormatException)
            {

            }
            catch (OverflowException)
            {

            }
        }
        public bool numValido(int num)
        {
            int min = 0;
            int max = 255;
            if(num>=min && num <= max)
            {
                return true;
            }
            return false;
        }
    }
}
