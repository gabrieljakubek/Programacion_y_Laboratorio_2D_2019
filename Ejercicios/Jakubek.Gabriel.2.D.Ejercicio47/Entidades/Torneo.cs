using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T: Equipo
    {
        #region Atributos
        private List<T> equipos;
        private string nombre;
        #endregion

        #region Propiedad
        public string JugarPartido
        {
            get
            {
                Random azar1 = new Random(DateTime.Now.Millisecond);
                System.Threading.Thread.Sleep(500);
                Random azar2 = new Random(DateTime.Now.Millisecond);
                return this.CalcularPartido(equipos[azar2.Next(0, equipos.Count)], equipos[azar2.Next(0, equipos.Count)]);
            }
        }
        #endregion

        #region Constructor
        public Torneo(string nombre)
        {
            this.equipos = new List<T>();
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Nombre del torneo: " + this.nombre);
            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("Los equipos integrantes son:");
            stringBuilder.AppendLine("");
            foreach (T item in this.equipos)
            {
                stringBuilder.AppendLine(item.Ficha());
            }
            return stringBuilder.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random azar1 = new Random(DateTime.Now.Millisecond);
            System.Threading.Thread.Sleep(500);
            Random azar2 = new Random(DateTime.Now.Millisecond);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} [{1}] - [{2}] {3}", equipo1.Nombre,azar1.Next(0,20) , azar2.Next(0,20), equipo2.Nombre);
            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            bool retorno=false;
            foreach (T item in torneo.equipos)
            {
                if(item == equipo)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        #endregion

        #region Operadores
        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            bool chequeo=false;
            foreach (T item in torneo.equipos)
            {
                if(item==equipo)
                {
                    chequeo = true;
                    break;
                }
            }
            if(!chequeo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }
        #endregion
    }
}
