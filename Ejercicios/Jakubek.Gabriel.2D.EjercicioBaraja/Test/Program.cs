using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja<int> baraja = new Baraja<int>();
            baraja.AgregarNaipe(5);
            baraja.AgregarNaipe(7);
            baraja.AgregarNaipe(8);
            Console.WriteLine(baraja.ObtenerNaipe());
            Console.ReadLine();
            Console.WriteLine(baraja.ObtenerNaipe());
            Console.ReadLine();
            Console.WriteLine(baraja.ObtenerNaipe());
            Console.ReadLine();

        }
    }
}
