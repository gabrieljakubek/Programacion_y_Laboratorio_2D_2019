using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36_Entidades
{
    public class Competencia
    {
        #region Enumerador
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        #endregion

        #region Atributos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        private static Random alearotio = new Random(DateTime.Now.TimeOfDay.Hours);
        #endregion

        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVentas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }
        #endregion

        #region Constructores
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        #region Metodos

        #endregion

        #region Operadores
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = true;
            if (c == a && c.competidores.Count < c.cantidadCompetidores)
            {
                foreach (VehiculoDeCarrera item in c.competidores)
                {
                    if (item == a)
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            else
            {
                retorno = false;
            }

            if (retorno)
            {
                a.EnCompetencia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.CantidadCombustible = (short)Competencia.alearotio.Next(15, 100);
                c.competidores.Add(a);
            }

            return retorno;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            if (c.tipo == TipoCompetencia.MotoCross && a is MotoCross || c.tipo == TipoCompetencia.F1 && a is AutoF1)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        #endregion
    }
}
