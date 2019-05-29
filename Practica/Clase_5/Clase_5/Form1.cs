using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Nombre: {txtNombre.Text}");
            mensaje.AppendLine($"Apellido: {txtApellido.Text}");
            mensaje.AppendLine($"Email: {txtEmail.Text}");
            mensaje.AppendLine($"Contraseña: {txtContraseña.Text}");

            MessageBox.Show(mensaje.ToString());
        }
    }
}
