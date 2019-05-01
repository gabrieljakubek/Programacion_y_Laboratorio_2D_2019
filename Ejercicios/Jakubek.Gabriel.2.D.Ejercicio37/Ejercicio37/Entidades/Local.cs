using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        #region Atributo
        protected float costo;
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Constructor
        public Local(Llamada llamada, float costo) : this(llamada.NroDestino, llamada.Duracion, llamada.NroOrigen, costo)
        { }
        public Local(string origen, float duracion, string nroDestino, float costo) : base(duracion, nroDestino, origen)
        {
            this.costo = costo;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendLine("El costo de la llamada es de: $" + this.CostoLlamada);
            return stringBuilder.ToString();
        }
        #endregion
    }
}
