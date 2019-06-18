using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {
        static int cantidadAsteriscos=1;
        static int cantidadPisos;
        static bool auxBool;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";

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

            for (int i = 0; i < cantidadPisos; i++)
            {
                for (int j = 0; j < cantidadAsteriscos; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                cantidadAsteriscos += 2;
            }
            Console.ReadKey();
        }
    }
}
