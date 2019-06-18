using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36_Entidades
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos
        private short callosDeFuerza;
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }
        public AutoF1(short numero, string escuderia, short cabllosDeFuerza) : this(numero, escuderia)
        {
            this.callosDeFuerza = cabllosDeFuerza;
        }
        #endregion

        #region Metodo
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("Caballos de fuerza: " + this.callosDeFuerza);
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            bool retorno = false;
            if (a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.callosDeFuerza == a2.callosDeFuerza)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion
    }
}
