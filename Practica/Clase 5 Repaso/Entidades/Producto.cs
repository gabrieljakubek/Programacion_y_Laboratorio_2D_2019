using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion

        #region Propiedades
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }
        #endregion

        #region Constructor
        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region Metodos
        public static string MostrarProducto(Producto p)
        {
            return $"El Codigo de barra es: {(string)p} Marca: {p.marca} Precio: {p.precio}\r\n";
        }
        #endregion

        #region Operadores
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return (string)p == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is null || p2 is null)
            {
                return false;
            }
            else
            {
                return (string)p1 == (string)p2 && p1.codigoDeBarra == p2.codigoDeBarra;
            }
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Producto)
            {
                return this == (Producto)obj;
            }
            else if (obj is string)
            {
                return this == (string)obj;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
