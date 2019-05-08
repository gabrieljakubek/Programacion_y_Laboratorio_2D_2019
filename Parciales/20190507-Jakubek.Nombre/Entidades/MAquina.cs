using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        #region Atributos
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;
        #endregion

        #region Propiedades
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

        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.nombre);
                foreach (Periferico item in this.perifericos)
                {
                    sb.AppendLine(item.ExponerDatos());
                }
                return sb.ToString();
            }
        }

        public int CantidadMaximaPerifericos
        {
            get
            {
                return this.cantidadMaxPerifericos;
            }
            set
            {
                if (value < 1)
                {
                    this.cantidadMaxPerifericos = 1;
                }
                else if (value > 4)
                {
                    this.cantidadMaxPerifericos = 4;
                }
                else
                {
                    this.cantidadMaxPerifericos = value;
                }
            }
        }
        #endregion

        #region Cosntructores
        private Maquina()
        {
            this.perifericos = new List<Periferico>();
            this.cantidadMaxPerifericos = 3;
        }

        public Maquina(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecargas operadores
        public static bool operator ==(Maquina m, Periferico p)
        {
            bool retorno = false;
            foreach (Periferico item in m.perifericos)
            {
                if (item == p)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }

        public static string operator +(Maquina m, Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            if (m.cantidadMaxPerifericos <= m.CantidadMaximaPerifericos && m != p)
            {
                m.perifericos.Add(p);
                sb.Append("Periferico conectado!");
            }
            else
            {
                sb.Append("No se pudo conectar el dispositivo");
            }
            return sb.ToString();
        }

        public static string operator -(Maquina m, Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            if (m == p)
            {
                foreach (Periferico item in m.perifericos)
                {
                    if (item == p)
                    {
                        m.perifericos.Remove(item);
                    }
                }

                sb.Append("Periferico desconectado!");
            }
            else
            {
                sb.Append("No se pudo desconectar el dispositivo");
            }
            return sb.ToString();
        }
        #endregion
    }
}
