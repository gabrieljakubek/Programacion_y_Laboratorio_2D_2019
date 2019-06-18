using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static int numero;
        static bool bufferBool;
        static double cuadrado;
        static double cubo;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";
            do
            {
                Console.Write("Ingrese un numero mayor a 0: ");
                bufferBool = int.TryParse(Console.ReadLine(), out numero);
                if (numero < 0 || numero == 0)
                {
                    Console.WriteLine("Error. Reingresar el numero!");
                }
                else
                {
                    bufferBool = true;
                }
            } while (bufferBool == false);
            cuadrado = (double)Math.Pow((double)numero, 2);
            cubo = (double)Math.Pow((double)numero, 3);
            Console.WriteLine("{0} al cuadrado es de: {1}", numero, cuadrado);
            Console.WriteLine("{0} al cubo es de: {1}", numero, cubo);

        }
    }
}
