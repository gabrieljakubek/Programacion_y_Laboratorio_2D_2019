using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Equipo
    {
        #region Atributos
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region Constructores
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecargas Operdores
        public static bool operator +(Equipo e, Jugador j)
        {
            bool flag = false;
            if (!(e is null) && !(j is null))
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (item == j)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag != true && (e.jugadores.Count < e.cantidadDeJugadores))
                {
                    e.jugadores.Add(j);
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
