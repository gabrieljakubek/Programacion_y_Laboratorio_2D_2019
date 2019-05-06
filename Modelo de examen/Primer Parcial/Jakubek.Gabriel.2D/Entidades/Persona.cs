using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos de la persona
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder("Nombre: " + this.nombre);
            sb.AppendLine("Apellido: " + this.apellido);
            sb.AppendLine("Edad: " + this.edad);
            sb.AppendLine("DNI: " + this.dni);
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        #endregion
    }
}
