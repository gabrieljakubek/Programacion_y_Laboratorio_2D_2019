using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        #region Atributos;
        private string equipo;
        private DateTime fechaCreacion;
        #endregion

        #region Propiedades
        public string Nombre { get { return this.equipo; } }
        public DateTime FechaCreacion { get { return this.fechaCreacion; } }
        #endregion

        #region Constructor
        public Equipo(string equipo, DateTime fechaCreacion)
        {
            this.equipo = equipo;
            this.fechaCreacion = fechaCreacion;
        }
        #endregion

        #region Metodos
        public string Ficha()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("{0} fundado el {1}\r\n", this.equipo, this.fechaCreacion.ToString("dd/MM/yyyy"));
            return builder.ToString();
        }
        #endregion

        #region Sobrecarga
        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return equipo1.equipo == equipo2.equipo && equipo1.fechaCreacion == equipo2.fechaCreacion;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }
        #endregion

    }
}
