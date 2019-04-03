using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        #region Atributos
        Producto[] productos;
        int ubicacionEstantes;
        #endregion

        #region Constructor
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstantes = ubicacion;
        }
        #endregion

        #region Propiedades 
        public Producto[] GetProductos
        {
            get
            {
                return this.productos;
            }
        }
        #endregion
        #region Metodos
        public static string MostrarEstante(Estante e)
        {
            string retorno = "";
            foreach (Producto item in e.productos)
            {
                if (!(e.productos is null))
                {
                    retorno += $"{Producto.MostrarProducto(item)}";
                }
            }
            retorno += $"\r\nUbicacion del estante: {e.ubicacionEstantes}";
            return retorno;
        }
        #endregion

        #region Operdores
        public static bool operator ==(Estante e, Producto p)
        {
            bool retorno = false;
            foreach (Producto item in e.productos)
            {
                    retorno = item == p;
                    break;
            }
            return retorno;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is null && e!=p)
                {
                    e.productos[i] = p;
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!(e.productos[i] is null) && e.productos[i] == p)
                {
                    e.productos[i] = null;
                }
            }
            return e;
        }

        public override bool Equals(object obj)
        {
            if (obj is Estante)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
