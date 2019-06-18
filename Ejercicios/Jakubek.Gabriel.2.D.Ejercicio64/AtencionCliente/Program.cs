using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AtencionCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio negocio = new Negocio(caja1, caja2);
            List<string> clientes = negocio.Clientes;
            clientes.Add("Juan");
            clientes.Add("Marta");
            clientes.Add("Sandra");
            clientes.Add("Pedro");
            clientes.Add("Carlos");

            Thread t1 = new Thread(negocio.AsignarCaja);
            Thread t2 = new Thread(caja1.AtenderCliente);
            t2.Name = "Caja 1";
            Thread t3 = new Thread(caja2.AtenderCliente);
            t3.Name = "Caja 2";
            t1.Start();
            t1.Join();
            t2.Start();
            t3.Start();
            Console.ReadLine();
            if (t1.IsAlive)
            {
                t1.Abort();
            }
            if (t2.IsAlive)
            {
                t2.Abort();
            }
            if (t3.IsAlive)
            {
                t3.Abort();
            }
        }
    }
}
