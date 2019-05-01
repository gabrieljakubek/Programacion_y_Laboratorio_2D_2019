using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    public abstract class Sobreescrito
    {
        #region Atributos
        protected string miAtributo;
        #endregion

        #region Propiedades
        public abstract string MiPropiedad { get; }
        #endregion

        #region Constructor
        public Sobreescrito()
        {
            miAtributo = "Probar abstracto";
        }
        #endregion

        #region Metodos
        public abstract string MiMetodo();
        #endregion
        #region Sobrecargas
        public override string ToString()
        {
            return "Este es mi metodo ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            return typeof(Sobreescrito) == obj.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
        #endregion
    }
}
