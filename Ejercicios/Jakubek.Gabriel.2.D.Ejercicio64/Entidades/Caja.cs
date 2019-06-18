using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caja
    {
        private List<string> filaCliente;

        public List<string> FilaCliente
        {
            get
            {
                return this.filaCliente;
            }
        }

        public Caja()
        {
            this.filaCliente = new List<string>();
        }

        public void AtenderCliente()
        {
            for (int i = 0; i < this.filaCliente.Count; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Cliente: {0} en Caja: {1}", filaCliente[i], Thread.CurrentThread.Name);
                filaCliente.Remove(filaCliente[i]);
                i--;
                Thread.Sleep(2000);
                Console.WriteLine(sb.ToString());
            } 
        }
    }
}
