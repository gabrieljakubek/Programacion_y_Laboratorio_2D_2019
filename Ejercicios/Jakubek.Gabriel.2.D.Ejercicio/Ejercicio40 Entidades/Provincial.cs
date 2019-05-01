using System.Text;

namespace Ejercicio40_Entidades
{
    public class Provincial : Llamada
    {
        #region Atributos
        protected Franja franjaHoraria;
        #endregion

        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroDestino, miFranja, llamada.Duracion, llamada.NroOrigen)
        {

        }
        public Provincial(string origen, Franja miFranaja, float duracion, string nroDestino) : base(duracion, nroDestino, origen)
        {
            this.franjaHoraria = miFranaja;
        }
        #endregion

        #region Metodos
        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        retorno = duracion * (float)0.99;
                    }
                    break;
                case Franja.Franja_2:
                    {
                        retorno = duracion * (float)1.25;
                    }
                    break;
                case Franja.Franja_3:
                    {
                        retorno = duracion * (float)0.66;
                    }
                    break;
            }
            return retorno;
        }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.Mostrar());
            stringBuilder.AppendLine("La franja horarioa es:" + this.franjaHoraria);
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

        #region Enumerador
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        #endregion
    }
}
