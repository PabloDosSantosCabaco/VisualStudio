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

namespace Servicios_Archivos_Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDir_Click(object sender, EventArgs e)
        {
            string directorio = txtDir.Text.Trim();
            if (directorio != "")
            {
                cambiarDirectorioActual(rutaFormateada(directorio));
            }
        }
        public void cambiarDirectorioActual(string actual)
        {
            bool error = false;
            try {
                if (actual == "")
                {
                    error = true;
                }
                else
                {
                    Directory.SetCurrentDirectory(actual);
                }
            }
            catch (FileNotFoundException)
            {
                error = true;
            }
            catch (IOException)
            {
                error = true;
            }
            if (error)
            {
                lblErrores.Text = "Este directorio no existe.";
                return;
            }
            lblErrores.Text = "";
            string directorio = Directory.GetCurrentDirectory();
            txtDir.Text = rutaFormateada(directorio);
            rellenarLista(rutaFormateada(directorio), lstDirs, true);
            rellenarLista(rutaFormateada(directorio), lstFiles, false);
        }
        public string rutaFormateada(string rutaAntigua)
        {
            string nuevaRuta = "";
            string aux = "";
            bool inicioVar = false;
            for(int i=0; i<rutaAntigua.Length; i++)
            {
                if ((rutaAntigua[i]+"") == "%")
                {
                    inicioVar = !inicioVar;
                    if (!inicioVar)
                    {
                        try
                        {
                            nuevaRuta += Environment.GetEnvironmentVariable(aux);
                        }
                        catch (ArgumentNullException)
                        {
                            return "";
                        }
                    }
                }
                if(inicioVar && (rutaAntigua[i] + "") != "%")
                {
                    aux += rutaAntigua[i];
                }
                else if((rutaAntigua[i] + "") != "%")
                {
                    nuevaRuta += rutaAntigua[i];
                }
            }
            return nuevaRuta;
        }
        public void rellenarLista(string ruta, ListBox lista, bool dirs)
        {
            borrarLista(lista);
            DirectoryInfo dInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
            if (dirs)
            {
                lista.Items.Add("..");
                for (int i = 0; i < dInfo.GetDirectories().Length; i++)
                {
                    lista.Items.Add(dInfo.GetDirectories()[i]);
                }
            }
            else
            {
                for (int i = 0; i < dInfo.GetFiles().Length; i++)
                {
                    lista.Items.Add(dInfo.GetFiles()[i]);
                }
            }
        }
        public void borrarLista(ListBox lista)
        {
            lista.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void LstDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambiarDirectorioActual(lstDirs.SelectedItem.ToString());
        }

        private void LstFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(lstFiles.SelectedItem.ToString());
            if (f.Extension == ".txt")
            {
            string line = "";
                using(StreamReader sr = new StreamReader(f.FullName))
                {
                    txtFiles.Text = (sr.ReadToEnd());
                }
            }
        }
    }
}
