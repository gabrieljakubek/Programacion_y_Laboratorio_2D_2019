using Archivos;
using Entidades;
using Patentes;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

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
                Thread hilo = new Thread(new ParameterizedThreadStart(vp.MostrarPatente));
                threads.Add(hilo);
                hilo.Start(cola.Dequeue());
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
            Xml<List<Patente>> xml = new Xml<List<Patente>>();
            List<Patente> patentes;
            try
            {
                xml.Leer("patentes", out patentes);
                foreach (Patente item in patentes)
                {
                    cola.Enqueue(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.IniciarSimulacion();
            }
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto texto = new Texto();
            try
            {
                texto.Leer("patentes", out cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.IniciarSimulacion();
            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            try
            {
                sql.Leer("patentes", out cola);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.IniciarSimulacion();
            }
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
