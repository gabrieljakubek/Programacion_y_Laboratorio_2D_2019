using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Baraja<T>
    {
        List<T> baraja;
        public Baraja()
        {
            this.baraja = new List<T>();
        }

        public bool AgregarNaipe(T naipe)
        {
            bool retorno = false;
            foreach (T item in this.baraja)
            {
                if (Object.Equals(item, naipe))
                {
                    retorno = true;
                    break;
                }
            }
            if(!retorno)
            {
                this.baraja.Add(naipe);
            }
            return retorno;
        }

        public T ObtenerNaipe()
        {
            T naipe = this.baraja[new Random().Next(0, this.baraja.Count)];
            this.baraja.Remove(naipe);
            return naipe;
        }
    }
}
