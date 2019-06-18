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

namespace FrmHilos
{
    public partial class Form1 : Form
    {
        //bool[] clickeos;
        List<Thread> hilos;
        int[] contador;
        public Form1()
        {
            InitializeComponent();
            //clickeos = new bool[] { false, false, false, false };
            hilos = new List<Thread>();
            hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
            hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
            hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
            hilos.Add(new Thread(new ParameterizedThreadStart(sumar)));
            contador = new int[] { 0, 0, 0, 0 };
            int i = 0;
            foreach (Thread t in hilos)
            {
                t.Start(i);
                i++;
            }
        }

        private void tmrUno_Tick(object sender, EventArgs e)
        {

        }

        private void btnUno_Click(object sender, EventArgs e)
        {

        }

        private void btnDos_Click(object sender, EventArgs e)
        {

        }

        private void btnTres_Click(object sender, EventArgs e)
        {

        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {

        }

        public void sumar(object o)
        {
            int posicion = (int)o;
            while (this.contador[posicion] < 1000)
            {
                try
                {
                    Thread.Sleep(100);
                    this.contador[posicion]++;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void mostrar(int posicion, int numero)
        {
            switch (posicion)
            {
                case 0:
                    if (this.txtUno.InvokeRequired)
                    {
                        this.txtUno.BeginInvoke((MethodInvoker)delegate () { this.txtUno.Text = numero.ToString(); });
                    }
                    else
                    {
                        this.txtUno.Text = numero.ToString();
                    }
                    break;
                case 1:
                    if (this.txtDos.InvokeRequired)
                    {
                        this.txtDos.BeginInvoke((MethodInvoker)delegate () { this.txtDos.Text = numero.ToString(); });
                    }
                    else
                    {
                        this.txtDos.Text = numero.ToString();
                    }
                    break;
                case 2:
                    if (this.txtTres.InvokeRequired)
                    {
                        this.txtTres.BeginInvoke((MethodInvoker)delegate () { this.txtTres.Text = numero.ToString(); });
                    }
                    else
                    {
                        this.txtTres.Text = numero.ToString();
                    }
                    break;
                case 3:
                    if (this.txtCuatro.InvokeRequired)
                    {

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
