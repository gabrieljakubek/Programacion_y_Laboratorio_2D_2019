using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio43_Entidades
{
    public class CompetenciaNoDisponibleException : Exception
    {
        #region Atributos
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region Propiedades
        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }
        #endregion

        #region Constructores
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        { }
        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion

        #region Sobrecarga
        public override string ToString()
        {
            Exception exception = this.InnerException;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Excepcion en el metodo {0} de la clase {1}\r\n", this.nombreMetodo, this.nombreClase);
            stringBuilder.AppendLine(this.Message);
            exception = this.InnerException;
            while (!(exception.InnerException is null))
            {
                stringBuilder.AppendLine(exception.Message + "\t");
                exception = exception.InnerException;
            }
            return stringBuilder.ToString();
        }
        #endregion
    }
}
