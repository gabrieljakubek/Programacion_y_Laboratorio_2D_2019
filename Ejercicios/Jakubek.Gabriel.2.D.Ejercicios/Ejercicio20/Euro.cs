using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        #region Atributos
        private double cantidad;
        private static float cotizRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            cotizRespectoDolar = (float)((1 * 1) / 1.16);
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, float cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return cotizRespectoDolar;
        }
        #endregion

        #region Operadores
        public static explicit operator Pesos(Euro e)
        {
            double retorno;
            retorno = e.cantidad / Pesos.GetCotizacion();
            return new Pesos(retorno);
        }

        public static explicit operator Dolar(Euro e)
        {
            double retorno;
            retorno = e.cantidad / Dolar.GetCotizacion();
            return new Dolar(retorno);
        }

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e.cantidad == ((Euro)p).cantidad;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e.cantidad == ((Euro)d).cantidad;
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.cantidad;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return e.cantidad + ((Euro)d).cantidad;
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return e.cantidad - ((Euro)d).cantidad;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return e.cantidad + ((Euro)p).cantidad;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return e.cantidad - ((Euro)p).cantidad;
        }
        #endregion
    }
}
