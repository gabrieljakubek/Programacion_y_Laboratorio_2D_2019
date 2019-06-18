using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private Caja caja1;
        private Caja caja2;
        private List<string> clientes;

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }

        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }

        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public Negocio(Caja c1, Caja c2)
        {
            this.clientes = new List<string>();
            this.caja1 = c1;
            this.caja2 = c2;
        }

        public void AsignarCaja()
        {
            List<string> clientes1 =this.caja1.FilaCliente;
            List<string> clientes2 = this.caja2.FilaCliente;
            Console.WriteLine("Asignando cajas...");
            foreach (string cliente in this.clientes)
            {
                Thread.Sleep(1000);
                if(clientes1.Count <= clientes2.Count)
                {
                    clientes1.Add(cliente);
                }
                else
                {
                    clientes2.Add(cliente);
                }
            }
        }
    }
}
