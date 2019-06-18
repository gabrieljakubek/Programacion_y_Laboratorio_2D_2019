using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        int contador = 0;
        Thread hilo;
        delegate void callback();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //timerUno.Start(); //Ejercicio 2
            MostrarHora();
            hilo = new Thread(Actualizar);
            hilo.Start();


        }

        public void MostrarHora()
        {
            //if (this.lblHora.InvokeRequired)
            //{
            //    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
            //    {
            //        lblHora.Text = DateTime.Now.ToString();
            //    });
            //}
            //else
            //{
            //    lblHora.Text = DateTime.Now.ToString();
            //}

            if (this.lblHora.InvokeRequired)
            {
                callback back = new callback(MostrarHora);
                lblHora.Invoke(back);
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString();
            }
        }

        public void Actualizar()
        {
            while (true)
            {
                MostrarHora();
                Thread.Sleep(200);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHora();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hilo.IsAlive)
            {
                hilo.Abort();
            }
        }
    }
}
