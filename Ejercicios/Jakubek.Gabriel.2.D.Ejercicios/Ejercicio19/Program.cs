using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador(5);
            long numero1 = 78;
            long numero2 =6;
            string textoA="Hola";
            string textoB = " Mundo";
            Console.WriteLine(sumador.Sumar(numero1, numero2));
            Console.WriteLine(sumador.Sumar(textoA, textoB));
            Console.ReadKey();
        }
    }
}
