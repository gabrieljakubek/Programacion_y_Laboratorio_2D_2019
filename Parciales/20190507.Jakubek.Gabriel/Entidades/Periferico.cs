using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        #region Atributos
        private EConector conector;
        private string marca;
        private string modelo;
        #endregion

        #region Constructor
        public Periferico(string marca, string modelo, EConector conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
        }
        #endregion

        #region Metodos
        public abstract string ExponerDatos();

        /// <summary>
        /// Retorna los datos del periferico que se le pasa
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} <Puerto: {2}>",p.marca,p.modelo,p.conector);
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga Operadores
        public static bool operator ==(Periferico p1, Periferico p2)
        {
            bool retorno = false;
            if(p1.marca == p2.marca&&p1.modelo == p2.modelo)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator != (Periferico p1, Periferico p2)
        {
            return !(p1 == p2);
        }
        #endregion
    }
}
