using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37_Entidades
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
                            retorno += ((Local)item).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada item in listaLlamadas)
                    {
                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada item in listaLlamadas)
                    {
                        if (item is Provincial)
                        {
                            retorno += ((Provincial)item).CostoLlamada;
                        }
                        else if (item is Local)
                        {
                            retorno += ((Local)item).CostoLlamada;
                        }
                    }
                    break;
                default:
                    break;
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Razon social: " + this.razonSocial);
            stringBuilder.AppendLine("Las ganancias por llamadas totales: $" + this.GananciasTotal);
            stringBuilder.AppendLine("Las ganancias por llamadas locales: $" + this.GananciasPorLocal);
            stringBuilder.AppendLine("Las ganancias por llamadas provinciales: $" + this.GananciasPorProvincia);
            stringBuilder.AppendLine("Listado detallado de las llamadas:\n");
            foreach (Llamada item in listaLlamadas)
            {
                if (item is Local)
                {
                    stringBuilder.AppendLine(((Local)item).Mostrar());
                }
                else if (item is Provincial)
                {
                    stringBuilder.AppendLine(((Provincial)item).Mostrar());
                }
            }
            return stringBuilder.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
