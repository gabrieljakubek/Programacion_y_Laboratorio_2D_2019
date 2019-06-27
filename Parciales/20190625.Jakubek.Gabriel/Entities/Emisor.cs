using System;
using System.Xml.Serialization;

namespace Entities
{
    /// <summary>
    /// Product types 
    /// </summary>
    public enum EProducto
    {
        SQLDatabase,
        MonitoringApp,
        AppHosting
    }

    [Serializable]
    public abstract class Emisor
    {
        private EProducto producto;
        private string mensaje;

        public EProducto Producto { get => producto; set => producto = value; }

        public string Mensaje { get => mensaje; set => mensaje = value; }

        public abstract void EnviarMensaje();

        [XmlIgnore]
        public EnviarMensajeDelegate EventMensaje
        {
            get
            {
                return this.eventMensaje;
            }
            set
            {
                this.eventMensaje += value;
            }
        }

        public override string ToString()
        {
            return $"{Mensaje} - {Producto}";
        }

        protected Emisor(string mensaje, EProducto producto)
        {
            this.Mensaje = mensaje;
            this.Producto = producto;
        }

        public Emisor()
        {

        }

        [field: NonSerialized]
        protected event EnviarMensajeDelegate eventMensaje;
    }
}
