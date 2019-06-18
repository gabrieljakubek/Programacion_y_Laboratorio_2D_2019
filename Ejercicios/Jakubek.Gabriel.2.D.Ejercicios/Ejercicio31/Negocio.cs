using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        #region Atributos
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;
        #endregion

        #region Priopiedad
        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                if (this != value)
                {
                    bool retorno = this + value;
                }
            }
        }

        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count();
            }
        }
        #endregion

        #region Constructor
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecargas Operadores
        public static bool operator +(Negocio n, Cliente c)
        {
            if (n == c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente item in n.clientes)
            {
                if (item == c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }

        #endregion
    }
}
