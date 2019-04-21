using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static int cantidadAsteriscos = 1;
        static int cantidadEspacios;
        static int cantidadPisos;
        static bool auxBool;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            do
            {
                Console.Write("Ingrese la cantidad de pisos de la piramide: ");
                int.TryParse(Console.ReadLine(), out cantidadPisos);
                if (cantidadPisos < 0 || cantidadPisos == 0)
                {
                    Console.WriteLine("Error. Reingresar solamente numeros > 1!");
                }
                else
                {
                    auxBool = true;
                }
            } while (!auxBool);

            cantidadEspacios = cantidadPisos - 1;
            for (int i = 0; i < cantidadPisos; i++)
            {
                for (int k = cantidadEspacios; k > 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < cantidadAsteriscos; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                cantidadAsteriscos += 2;
                cantidadEspacios--;
            }
            Console.ReadKey();

        }
    }
}
