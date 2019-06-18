using System.Collections.Generic;
using System.Text;

namespace Ejercicio41_Entidades
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaLlamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincia
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaLlamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float retorno = 0;
            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada item in listaLlamadas)
                    {
                        if (item is Local)
                        {
                            retorno += item.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada item in listaLlamadas)
                    {
                        if (item is Provincial)
                        {
                            retorno += item.CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada item in listaLlamadas)
                    {

                        retorno += item.CostoLlamada;

                    }
                    break;
                default:
                    break;
            }
            return retorno;
        }

        private string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Razon social: " + this.razonSocial);
            stringBuilder.AppendLine("Las ganancias por llamadas totales: $" + this.GananciasTotal);
            stringBuilder.AppendLine("Las ganancias por llamadas locales: $" + this.GananciasPorLocal);
            stringBuilder.AppendLine("Las ganancias por llamadas provinciales: $" + this.GananciasPorProvincia);
            stringBuilder.AppendLine("Listado detallado de las llamadas:\n");
            foreach (Llamada item in listaLlamadas)
            {

                stringBuilder.AppendLine(item.ToString());

            }
            return stringBuilder.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaLlamadas.Add(nuevaLlamada);
        }
        #endregion

        #region Sobrecarga Operadores
        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita centralita, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada item in centralita.listaLlamadas)
            {
                if (item == llamada)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita centralita, Llamada llamada)
        {
            return !(centralita == llamada);
        }

        public static Centralita operator +(Centralita centralita, Llamada nuevaLlamada)
        {
            if (centralita != nuevaLlamada)
            {
                centralita.AgregarLlamada(nuevaLlamada);
            }
            else
            {
                throw new CentralitaException("No se puede agregar mas llamadas!!!", "Centralita", "+");
            }
            return centralita;
        }
        #endregion
    }
}
