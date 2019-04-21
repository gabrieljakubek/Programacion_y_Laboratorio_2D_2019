using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        #region Atributos
        private double cantidad;
        private static float cotizRespectoDolar;
        #endregion

        #region Constructores
        static Pesos()
        {
            cotizRespectoDolar = (float)38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion) : this(cantidad)
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
        public static explicit operator Euro(Pesos p)
        {
            double retorno;
            retorno = p.cantidad * Euro.GetCotizacion();
            return new Euro(retorno);
        }

        public static explicit operator Dolar(Pesos p)
        {
            double retorno;
            retorno = p.cantidad / Pesos.GetCotizacion();
            return new Dolar(retorno);
        }

        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.cantidad == ((Pesos)d).cantidad;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator == (Pesos p, Euro e)
        {
            return p.cantidad == ((Pesos)e).cantidad;
        }

        public static bool operator != (Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator == (Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.cantidad + ((Pesos)e).cantidad;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.cantidad - ((Pesos)e).cantidad;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p.cantidad + ((Pesos)d).cantidad;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p.cantidad - ((Pesos)d).cantidad;
        }
        #endregion


    }
}
