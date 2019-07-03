using System;
using System.Threading;

namespace Entities
{
    [Serializable]
    public class EmisorDeWhatsapp : Emisor
    {
        private int numeroTelefono;

        public EmisorDeWhatsapp(string mensaje, EProducto producto)
            : base(mensaje, producto)
        {

        }

        public EmisorDeWhatsapp()
        {
        }

        public int NumeroTelefono
        {
            get { return this.numeroTelefono; }
            set
            {
                if (value > 1500000000 && value < 1600000000)
                {
                    this.numeroTelefono = value;
                }
                else
                {
                    throw new WhatsappException("Numero " + value + " fuera de rango");
                }
            }
        }

        /// <summary>
        /// Duerme el hilo durante 1 segundo y luego invoca al evento EventMensaje \
        /// pasándose a sí mismo(this) como parámetro.
        /// En caso de que no esté cargado el numero lanza un WhatsappException 
        /// indicando que el número no fue cargado.
        /// </summary>
        public override void EnviarMensaje()
        {
            if(!Object.Equals(this.numeroTelefono,null))//(!this.numeroTelefono.Equals(null)) this.numeroTelefono != null
            {
                Thread.Sleep(100);
                this.EventMensaje.Invoke(this);
            }
            else
            {
                throw new WhatsappException("El numero no está cargado");
            }

        }
    }
}
