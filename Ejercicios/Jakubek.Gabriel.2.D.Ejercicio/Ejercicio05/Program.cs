using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static int centro;
        static int paraAbajo;
        static int paraArriba;
        static int i;
        static int ingreso;
        static bool auxBool;

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            do
            {
                Console.Write("Ingrese el numero > 1 hasta el que se desea buscar los centros numericos: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso < 0 || ingreso == 0)
                {
                    Console.WriteLine("Error. Reingresar solamente numeros > 1!");
                }
                else
                {
                    auxBool = true;
                }
            } while (!auxBool);
            do
            {
                for (i = 1; i < centro; i++)
                {
                    paraAbajo += i;
                }
                for (i = centro + 1; i <= ingreso; i++)
                {
                    paraArriba += i;
                }

                if (paraAbajo == paraArriba)
                {
                    Console.Write(centro);
                }
                paraAbajo = 0;
                paraArriba = 0;
                centro++;
            } while (centro!=ingreso);
            Console.ReadKey();
        }
    }
}
