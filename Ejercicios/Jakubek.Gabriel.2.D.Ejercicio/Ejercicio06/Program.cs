using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static int ingreso;
        static int anoInicio;
        static int anoFinal;
        static bool auxBool;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";
            do
            {
                Console.Write("Ingrese el año apartir del que se desea buscar los años bisiestos: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso <= 0)
                {
                    Console.WriteLine("Error. Reingresar solamente numeros!");
                }
                else
                {
                    auxBool = true;
                    anoInicio = ingreso;
                }
            } while (!auxBool);
            do
            {
                Console.Write("Ingrese el año final hasta donde se desea buscar los años bisiestos: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso <= 0 || ingreso < anoInicio)
                {
                    Console.WriteLine("Error. Reingresar solamente numeros!");
                }
                else
                {
                    auxBool = true;
                    anoFinal = ingreso;
                }
            } while (!auxBool);
            Console.Write("Los años bisiestos son: ");
            for (int i = anoInicio; i <= anoFinal; i++)
            {
                if (i % 4 == 0 || i % 100 == 0 && i % 400 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
    }
}
