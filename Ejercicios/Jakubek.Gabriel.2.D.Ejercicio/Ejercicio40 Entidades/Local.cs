using System.Text;

namespace Ejercicio40_Entidades
{
    public class Local : Llamada
    {
        #region Atributo
        protected float costo;
        #endregion

        #region Propiedades
        public override float CostoLlamada
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

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendLine("El costo de la llamada es de: $" + this.CostoLlamada);
            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecarga Operadores
        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

    }
}
