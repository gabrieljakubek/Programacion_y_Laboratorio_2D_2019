using Controles;
using Entidades;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace _20190711_Final
{
    public partial class FrmAerolinea : Form
    {
        private Aeropuerto<Vuelo> aeropuerto;

        public FrmAerolinea()
        {
            InitializeComponent();

            this.aeropuerto = new Aeropuerto<Vuelo>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = (int)nudHorasDeVuelo.Value;
            Vuelo vuelo = new Vuelo(horas);
            int ejeY = this.aeropuerto + vuelo;

            this.Controls.Add(vuelo);
            vuelo.Location = new Point(0, ejeY);

            vuelo.Despegar();
        }

        private void FrmAerolinea_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aeropuerto.FinalizaVuelos();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Archivo<Vuelo>.Guardar(aeropuerto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException);
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                aeropuerto = Archivo<Vuelo>.Leer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException);
            }

        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este metodo");
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este metodo");
        }

        private void binarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este metodo");
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este metodo");
        }
    }
}
