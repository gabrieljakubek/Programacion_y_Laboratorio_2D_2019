using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region Propiedades
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion

        #region Constructor
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida que el equipo cumpla los requisitos establecidos
        /// </summary>
        /// <param name="e">El equipo a validar</param>
        /// <returns></returns>
        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            bool auxBool;
            Dictionary<Posicion, int> posi = new Dictionary<Posicion, int>();
            if (!(e is null))
            {
                foreach (var item in e.jugadores)
                {
                    auxBool = true;
                    foreach (var key in posi.Keys)
                    {
                        if (key == item.Posicion)
                        {
                            auxBool = false;
                        }
                    }
                    if (auxBool)
                    {
                        posi.Add(item.Posicion, 1);
                    }
                    else
                    {
                        posi[item.Posicion]++;
                    }
                }
                auxBool = posi.Count == Enum.GetValues(typeof(Posicion)).Length;
                if (!(e.directorTecnico is null) && auxBool && posi[Posicion.Arquero] == 1  && e.jugadores.Count == cantidadMaximaJugadores )
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region Sobrecargas Operadores
        /// <summary>
        /// Retorna la informacion del equipo
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            if (!(e is null))
            {
                sb.AppendLine("Nombre: " + e.nombre);
                if (e.directorTecnico is null)
                {
                    sb.AppendLine("Sin DT Asignado \r\n");
                }
                else
                {
                    sb.AppendLine("Director Tecnico: \r\n");
                    sb.Append(e.directorTecnico.Mostrar());
                }
                sb.AppendLine("Jugadores: \r\n");
                foreach (Jugador jugador in e.jugadores)
                {
                    sb.Append(jugador.Mostrar());
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Comprueba si un jugador ya se encuentra en el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;
            if (!(e is null) && !(j is null))
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {
                        retorno = true;
                        break;
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// Comprueba si un jugador no se encuentra en el equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        /// <summary>
        /// Agrega un jugador al equipo
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && j.ValidarAptitud() && e.jugadores.Count < Equipo.cantidadMaximaJugadores)
            {
                e.jugadores.Add(j);
            }
            return e;
        }
        #endregion
    }
}
