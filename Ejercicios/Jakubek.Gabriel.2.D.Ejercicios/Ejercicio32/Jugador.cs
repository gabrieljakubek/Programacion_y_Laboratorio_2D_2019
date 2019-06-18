using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Jugador
    {
        #region Atributos
        private int dni;
        private string nombre;
        private int partidoJugados;
        private float promedioGoles;
        private int totalGoles;
        #endregion

        #region Propiedad
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidoJugados;
            }
        }

        public float GetPromedioGoles
        {
            get
            {
                return totalGoles / partidoJugados;
            }
        }
        #endregion

        #region Constructor
        private Jugador()
        {
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidoJugados = totalPartidos;
        }
        #endregion

        #region Metodos
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("DNI: " + this.dni);
            stringBuilder.AppendLine("Nombre: " + this.nombre);
            stringBuilder.AppendLine("Partidos Jugados: " + this.partidoJugados);
            stringBuilder.AppendLine("Total Goles: " + this.totalGoles);
            stringBuilder.AppendLine("Promedio Goles: " + this.promedioGoles);
            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecarga Operador
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
