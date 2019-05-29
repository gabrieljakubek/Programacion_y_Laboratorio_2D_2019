using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase_8_Library;

namespace Clase_8
{
    public partial class frmEmpresa : Form
    {
        Empresa _empresa;

        public Empresa Empresa
        {
            get
            {
                return this._empresa;
            }
        }

        public frmEmpresa(Empresa empresa)
        {
            InitializeComponent();
            if (!(empresa is null))
            {
                txtRazonSocial.Text = empresa.RazonSocial;
                txtDireccion.Text = empresa.Direccion;
                mtxtGanancias.Text = empresa.Ganancias.ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float ganancias = float.Parse(this.mtxtGanancias.Text.Replace(".", ",").Substring(1, mtxtGanancias.Text.Length - 1));
            if (this._empresa == null)
            {
                this._empresa = new Empresa(txtRazonSocial.Text, txtDireccion.Text, float.Parse(mtxtGanancias.Text.Substring(1)));
            }
            else
            {
                this._empresa.RazonSocial = this.txtRazonSocial.Text;
                this._empresa.Direccion = this.txtDireccion.Text;
                this._empresa.Ganancias = ganancias;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
