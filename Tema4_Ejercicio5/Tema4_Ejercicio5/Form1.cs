using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_Ejercicio5
{
    public partial class Form1 : Form
    {
        int contador = 1;
        int contadorIcono = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            const string TITULO = "Título animado";

            this.Text = TITULO.Substring(TITULO.Length - contador, contador);
            contador++;
            contadorIcono++;
            if (contador > TITULO.Length)
            {
                contador = 1;
            }
            if (contadorIcono >= 2)
            {
                contadorIcono = 0;
                this.Icon = 
            }
            
        }
    }
}
