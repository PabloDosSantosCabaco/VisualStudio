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
    public partial class Form1 : Form
    {
        string[] valores = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "#", "0", "*"};
        int aumentoX = 52;
        int aumentoY = 54;

        int intentos = 3;
        string codigo = "1111";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 formPIN = new Form2(this);

            if(formPIN.ShowDialog() == DialogResult.OK)
            {

            }

            int aux = 0;

            Button[] botones = new Button[12];
            for(int i=0; i<valores.Length; i++)
            {
                aux++;
                if (aux % 3 == 0)
                {
                    aux = 0;

                }
                botones[i] = new Button();
                botones[i].Name = $"button{i}";
                botones[i].Location = new System.Drawing.Point(114+(aux*aumentoX), 122);
                botones[i].Size = new System.Drawing.Size(46, 48);
                botones[i].Text = valores[i];
                this.Controls.Add(botones[i]);
            }
        }
    }
}
