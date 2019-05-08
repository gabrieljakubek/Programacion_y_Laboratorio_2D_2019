using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado : Periferico
    {
        #region Atributos
        private EDistribucion distribucion;
        #endregion

        #region Cosntructor
        public Teclado(string marca, string modelo, EConector conector) : this(marca, modelo, conector, EDistribucion.Dvorak)
        {

        }

        public Teclado(string marca, string modelo, EConector conector, EDistribucion distribucion) : base(marca, modelo, conector)
        {
            this.distribucion = distribucion;
        }
        #endregion

        #region Metodos
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("TECLADO {0}\r\n", (string)this);
            sb.AppendLine("Distribución: " + this.distribucion);
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Teclado t, EDistribucion distribucion)
        {
            bool retorno = false;
            if (t.distribucion == distribucion)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t == distribucion);
        }
        #endregion


        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }
    }
}
