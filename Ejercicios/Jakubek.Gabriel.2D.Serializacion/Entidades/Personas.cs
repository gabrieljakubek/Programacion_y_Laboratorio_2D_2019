using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Personas
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int numeroDeTarjeta;

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value
;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }

        public Personas()
        { }

        public Personas(string nombre, string apellido, int dni, int numeroDeTarjeta)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.numeroDeTarjeta = numeroDeTarjeta;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} Apellido: {1} DNI: {2} Tarjeta: {3}",this.nombre,this.apellido,this.dni,this.numeroDeTarjeta);
            return sb.ToString();
        }
    }
}
