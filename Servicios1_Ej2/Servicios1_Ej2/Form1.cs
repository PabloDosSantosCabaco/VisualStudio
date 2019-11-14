using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios1_Ej2
{
    public partial class Form1 : Form
    {
        Process[] p;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            p = Process.GetProcesses();
            for(int i=0; i<p.Length; i++)
            {
                txtInfo.AppendText("PID: " + p[i].Id + Environment.NewLine+"Nombre: " + p[i].ProcessName + Environment.NewLine);
                if (!p[i].MainWindowTitle.Trim().Equals(""))
                {
                    txtInfo.AppendText("Título ventana: " + p[i].MainWindowTitle + Environment.NewLine);
                }
                txtInfo.AppendText("*******" + Environment.NewLine);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            if (comprobarPID())
            {
                try
                {
                    Process proceso = Process.GetProcessById(Convert.ToInt32(txtInput.Text));
                }
                catch (ArgumentException)
                {
                    txtInfo.Clear();
                    txtInfo.AppendText("El proceso con PID "+txtInput.Text+" no existe.");
                }
                catch (InvalidOperationException)
                {

                }
                foreach (Process pr in p)
                {
                    if (pr.Id == Convert.ToInt32(txtInput.Text))
                    {
                        txtInfo.Clear();
                        txtInfo.AppendText("Id: "+pr.Id+Environment.NewLine+"Nombre: "+pr.ProcessName+Environment.NewLine+"Comienzo: "+pr.StartTime);
                        txtInfo.AppendText(Environment.NewLine+"Tiempo total: "+pr.TotalProcessorTime+Environment.NewLine);
                        if (pr.Threads.Count > 0)
                        {
                            for(int i=0; i<pr.Threads.Count; i++)
                            {
                                txtInfo.AppendText("********");
                                txtInfo.AppendText("ID del subproceso " + (i + 1) + ":" + pr.Threads[i].Id + Environment.NewLine);
                                txtInfo.AppendText("Estado: " + pr.Threads[i].ThreadState + Environment.NewLine);
                                txtInfo.AppendText("Inicio: " + pr.Threads[i].StartTime + Environment.NewLine);
                            }
                        }
                    }
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (comprobarPID())
            {
                foreach (Process pr in p)
                {
                    if (pr.Id == Convert.ToInt32(txtInput.Text))
                    {
                        txtInfo.Clear();
                        txtInfo.AppendText("Id: " + pr.Id + Environment.NewLine + "Nombre: " + pr.ProcessName + Environment.NewLine + "Comienzo: " + pr.StartTime+Environment.NewLine);
                        pr.Close();
                        txtInfo.AppendText("Programa cerrado.");
                    }
                }
            }
        }

        private void BtnKill_Click(object sender, EventArgs e)
        {
            if (comprobarPID())
            {
                foreach (Process pr in p)
                {
                    if (pr.Id == Convert.ToInt32(txtInput.Text))
                    {
                        txtInfo.Clear();
                        txtInfo.AppendText("Id: " + pr.Id + Environment.NewLine + "Nombre: " + pr.ProcessName + Environment.NewLine + "Comienzo: " + pr.StartTime + Environment.NewLine);
                        pr.Kill();
                        txtInfo.AppendText("Programa muerto.");
                    }
                }
            }
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.Start(txtInput.Text);
            }
            catch (System.IO.FileNotFoundException)
            {
                txtInfo.Clear();
                txtInfo.AppendText(txtInput.Text + " no existe.");
            }
            catch (Win32Exception)
            {
                txtInfo.Clear();
                txtInfo.AppendText(txtInput.Text + " no existe. Win32Ex");
            }
            catch (ObjectDisposedException)
            {
                txtInfo.Clear();
                txtInfo.AppendText(txtInput.Text + " no existe. ObjectDisposed");
            }
        }
        public bool comprobarPID()
        {
            int num;
            if (!txtInput.Text.Trim().Equals(""))
            {
                try
                {
                    num = Convert.ToInt32(txtInput.Text);
                }
                catch (FormatException)
                {
                    num = 0;
                }
                catch (OverflowException)
                {
                    num = 0;
                }
                return true;
            }
            return false;
        }
    }
}
