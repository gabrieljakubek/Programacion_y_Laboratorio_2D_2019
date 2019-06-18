using System.Text;

namespace Ejercicio41_Entidades
{
    public abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion

        #region Constructor
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Metodos
        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Duracion: " + this.duracion);
            stringBuilder.AppendLine("Numero Origen: " + this.nroOrigen);
            stringBuilder.Append("Numero Destino: " + this.nroDestino);
            return stringBuilder.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion < llamada2.duracion)
            {
                retorno = -1;
            }

            return retorno;
        }
        #endregion

        #region Operadores sobrecargados
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool retorno = false;
            if (l1.Equals(l2) && l1.nroOrigen == l2.nroOrigen && l1.nroDestino == l2.nroDestino)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion

        #region Enumerador
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion
    }
}
