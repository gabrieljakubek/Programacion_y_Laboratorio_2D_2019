using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmisorException : Exception
    {
        public EmisorException():base("No hay emisor asociado")
        { }
    }
}
