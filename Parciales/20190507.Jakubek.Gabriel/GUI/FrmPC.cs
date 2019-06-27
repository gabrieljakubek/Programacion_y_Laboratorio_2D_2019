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

namespace GUI
{
    public partial class Form1 : Form
    {
        Maquina m;
        public Form1()
        {
            InitializeComponent();
            m = new Maquina();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m + new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value));
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m - new PlacaVideo(txtMarca.Text, txtModelo.Text, (int)nudMemoria.Value));
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            rtxtSystemInfo.Text = m.SystemInfo;
        }
    }
}
