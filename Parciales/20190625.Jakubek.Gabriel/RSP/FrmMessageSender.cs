using System.Threading;
using System.Windows.Forms;
using Entities;

namespace RSP
{

    public partial class FrmMessageSender : Form
    {
        public FrmMessageSender()
        {
        }

        private void EnviarMensajePorCanal1(string mensaje)
        {
            MessageBox.Show($"Se ejecuta el metodo1: {mensaje}");
        }

        private void EnviarMensajePorCanal2(string mensaje)
        {
            MessageBox.Show($"Se ejecuta el metodo2: {mensaje}");
        }

        private void BtnEnviarEmail_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Button2_Click");
        }

        private void BtnEnviarWhatsapp_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Button1_Click");
        }
    }

}
