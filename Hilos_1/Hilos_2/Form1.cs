using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            Process[] procesos = Process.GetProcesses();
            txtInfo.AppendText("PID\tNombre\t\tVentana" + Environment.NewLine);
            foreach (var p in procesos)
            {
                txtInfo.AppendText($"{p.Id}\t");
                string aux;
                if(p.ProcessName.Length > 15)
                {
                    aux = p.ProcessName.Substring(0, 12) + "...";
                }
                else
                {
                    aux = p.ProcessName;
                }
                txtInfo.AppendText($"{aux}\t\t{p.MainWindowTitle}" + Environment.NewLine);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int pid;
            try
            {
                pid = Convert.ToInt32(txtPID.Text.Trim());
                lblErrorPID.Text = "";
                if (comprobarProceso(pid))
                {
                    Process proceso = Process.GetProcessById(pid);
                    txtInfo.Clear();
                    txtInfo.AppendText($"Nombre: {proceso.ProcessName}" + Environment.NewLine);
                    txtInfo.AppendText($"PID: {proceso.Id}" + Environment.NewLine);
                    txtInfo.AppendText($"Comienzo: {proceso.StartTime}" + Environment.NewLine);
                    txtInfo.AppendText($"Módulos: {proceso.Modules.Count}" + Environment.NewLine);
                    for (int i = 0; i < proceso.Modules.Count; i++)
                    {
                        txtInfo.AppendText($"Modulo {i}: {proceso.Modules[i].ModuleName}" + Environment.NewLine);
                        txtInfo.AppendText($"Ruta {i}: {proceso.Modules[i].FileName}" + Environment.NewLine);
                    }
                    txtInfo.AppendText($"Subprocesos: {proceso.Threads.Count}" + Environment.NewLine);
                    for (int i = 0; i < proceso.Threads.Count; i++)
                    {
                        txtInfo.AppendText($"ID subproceso {i}: {proceso.Threads[i].Id}" + Environment.NewLine);
                        txtInfo.AppendText($"Inicio del subproceso {i}: {proceso.Threads[i].StartTime}" + Environment.NewLine);
                    }
                }
                else
                {
                    lblErrorPID.Text = "Este proceso no existe.";
                }
            }
            catch (OverflowException)
            {
                lblErrorPID.Text = "Este número es demasaido grande.";
            }
            catch (FormatException)
            {
                lblErrorPID.Text = "El valor introducido no es válido.";
            }
            catch (Win32Exception)
            {
                txtInfo.Clear();
                lblErrorPID.Text = "No se puede acceder a dicho proceso.";
            }
        }
        public bool comprobarProceso(int pid)
        {
            Process[] p = Process.GetProcesses();
            foreach (var proceso in p)
            {
                if (proceso.Id.Equals(pid))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            int pid;
            try
            {
                pid = Convert.ToInt32(txtPID.Text.Trim());
                lblErrorPID.Text = "";
                if (comprobarProceso(pid))
                {
                    Process proceso = Process.GetProcessById(pid);
                    txtInfo.Clear();
                    proceso.CloseMainWindow();
                }
            }
            catch (OverflowException)
            {
                lblErrorPID.Text = "Este número es demasaido grande.";
            }
            catch (FormatException)
            {
                lblErrorPID.Text = "El valor introducido no es válido.";
            }
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            int pid;
            try
            {
                pid = Convert.ToInt32(txtPID.Text.Trim());
                lblErrorPID.Text = "";
                if (comprobarProceso(pid))
                {
                    Process proceso = Process.GetProcessById(pid);
                    txtInfo.Clear();
                    proceso.Kill();
                }
            }
            catch (OverflowException)
            {
                lblErrorPID.Text = "Este número es demasaido grande.";
            }
            catch (FormatException)
            {
                lblErrorPID.Text = "El valor introducido no es válido.";
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPID.Text.Trim().Equals(""))
                {
                    lblErrorPID.Text = "Campo vacío. Introduca un PID.";
                }
                else
                {
                    Process.Start(txtPID.Text);
                    lblErrorPID.Text = "";
                }
            }
            catch (FileNotFoundException)
            {
                lblErrorPID.Text = "Este proceso no existe.";
            }
            catch (Win32Exception)
            {
                lblErrorPID.Text = "Este proceso no existe.";
            }
        }
    }
}
