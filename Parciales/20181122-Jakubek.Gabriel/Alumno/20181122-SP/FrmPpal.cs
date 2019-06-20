using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> threads;
        public FrmPpal()
        {
            InitializeComponent();
            this.cola = new Queue<Patente>();
            this.threads = new List<Thread>();
        }

        public void ProximaPatente(VistaPatente vp)
        {
            while (cola.Count > 0)
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                threads.Add(hilo);
                hilo.Start(cola.Dequeue());
            }
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(vistaPatente1);
            this.ProximaPatente(vistaPatente2);
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread item in this.threads)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }
    }
}
