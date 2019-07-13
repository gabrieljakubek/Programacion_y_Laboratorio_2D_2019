using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aeropuerto<T> where T : IAvion
    {
        private List<T> vuelos;

        public Aeropuerto()
        { vuelos = new List<T>(); }

        public static explicit operator String(Aeropuerto<T> a)
        {
            int contador =0;
            StringBuilder sb = new StringBuilder();
            foreach (IAvion item in a.vuelos)
            {
                if (item.Estado == EstadoVuelo.Volando)
                {
                    contador++;

                }
            }
            sb.Append("El aeropuerto cuenta con "+ contador + " vuelos en estado Volando");
            return sb.ToString();
        }


        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return a.vuelos.Count * 50;
        }

        public void FinalizaVuelos()
        {
            foreach (IAvion item in vuelos)
            {
                if (item.Estado == EstadoVuelo.Volando)
                {
                    item.Estrellar();
                }
            }
        }
    }
}
