using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        #region Atributos
        private double cantidad;
        private static float cotizRespectoDolar;
        #endregion

        #region Constructores
        static Dolar()
        {
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, float cotizacion) : this(cantidad)
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
        public static explicit operator Euro(Dolar d)
        {
            double retorno;
            retorno = d.cantidad * Euro.GetCotizacion();
            return new Euro(retorno);
        }

        public static explicit operator Pesos(Dolar d)
        {
            double retorno;
            retorno = d.cantidad * Pesos.GetCotizacion();
            return new Pesos(retorno);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return d.cantidad + ((Dolar)e).cantidad;
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d.cantidad + ((Dolar)p).cantidad;
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d.cantidad - ((Dolar)e).cantidad;
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d.cantidad - ((Dolar)p).cantidad;
        }

        public static bool operator == (Dolar d, Euro e)
        {
            return d.cantidad == ((Dolar)e).cantidad;
        }

        public static bool operator != (Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator == (Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator == (Dolar d, Pesos p)
        {
            return d.cantidad == ((Dolar)p).cantidad;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        #endregion
    }
}
