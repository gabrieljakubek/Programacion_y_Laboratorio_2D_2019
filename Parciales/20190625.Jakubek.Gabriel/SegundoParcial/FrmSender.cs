using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Entities;
using Persistencia;

namespace SegundoParcial
{
    public partial class FrmSender : Form
    {
        private readonly List<Thread> hilos;

        public FrmSender()
        {
            InitializeComponent();
            hilos = new List<Thread>();
        }

        private void FrmSender_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.AddRange(Enum.GetNames(typeof(EProducto)));
        }

        /// <summary>
        /// El botón Enviar Email debe crear un EmisorDeEmails, agregar al eventMensaje el 
        /// manejador “EmailDB.Guardar” y “MostrarMensaje” y ejecutar el método EnviarMensaje 
        /// (del objeto EmisorDeEmails) en un hilo nuevo. (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            if (richMensaje.Text != "" && cmbProducto.Text != "" && txtEmail.Text != "")
            {
                EmailDB email = new EmailDB();
                EmisorDeEmails emisor = new EmisorDeEmails(richMensaje.Text, (EProducto)Enum.Parse(typeof(EProducto), cmbProducto.Text), txtEmail.Text);
                emisor.EventMensaje = email.Guardar;
                emisor.EventMensaje = MostrarMensaje;
                Thread hilo = new Thread(emisor.EnviarMensaje);
                this.hilos.Add(hilo);
                hilo.Start();
            }
            else
            {
                MessageBox.Show("Debe ingresar datos en los campos!!");
            }
        }

        /// <summary>
        /// Email info utilizarán las clase EmailDb para traer la 
        /// información de la base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMailInfo_Click(object sender, EventArgs e)
        {
            richOutPut.Clear();
            EmailDB email = new EmailDB();
            List<EmisorDeEmails> lista = email.Leer();
            foreach (EmisorDeEmails item in lista)
            {
                richOutPut.Text += item.Mostrar() + "\r\n";
            }
        }

        /// <summary>
        /// El botón Enviar Whatsapp hace lo mismo con el objeto EmisorDeWhatsapp per 
        /// agrega al event eventMensaje el manejador “WhatsappTexto.Guardar” y “MostrarMensaje” 
        /// y ejecutar el método EnviarMensaje (del objeto EmisorDeEmails) en un hilo nuevo. 
        /// (Este método invocará al evento.)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSendWhat_Click(object sender, EventArgs e)
        {
            if ((richMensaje.Text != "" && cmbProducto.Text != "" && int.TryParse(txtTel.Text, out int convercion)))
            {
                WhatsappTexto texto = new WhatsappTexto();
                EmisorDeWhatsapp emisor = new EmisorDeWhatsapp(richMensaje.Text, (EProducto)Enum.Parse(typeof(EProducto), cmbProducto.Text), convercion);
                emisor.EventMensaje += texto.Guardar;
                emisor.EventMensaje += MostrarMensaje;
                Thread hilo = new Thread(emisor.EnviarMensaje);
                this.hilos.Add(hilo);
                hilo.Start();
            }
            else
            {
                MessageBox.Show("Debe ingresar datos en los campos!!");
            }
        }

        /// <summary>
        /// Whatsapp info utilizarán las clase WhatsappTexto para traer la información de la 
        /// base de datos y el archivo de texto dependiendo el caso.	
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWhatInfo_Click(object sender, EventArgs e)
        {
            richOutPut.Clear();
            WhatsappTexto whatsappTexto = new WhatsappTexto();
            richOutPut.Text = whatsappTexto.Leer();
        }

        /// <summary>
        /// recibe un objeto del tipo Emisor y muestra en un MessageBox el siguiente mensaje: 
        /// $"{mensaje.GetType().Name} - Se envió mensaje del producto: {mensaje.Producto}”
        /// </summary>
        /// <param name="emisor"></param>
        private void MostrarMensaje(Emisor emisor)
        {
            MessageBox.Show($"{emisor.GetType().Name} - Se envió mensaje del producto: {emisor.Producto}");
        }

        /// <summary>
        /// Cuando se cierra la aplicación abortar todos los hilos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSender_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Thread item in this.hilos)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }

    }
}
