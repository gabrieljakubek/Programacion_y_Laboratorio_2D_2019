using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static int numero;
        static int acumulador;
        static bool bufferBool;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            do
            {
                Console.Write("Ingrese el numero hasta el qúe se desea conocer los numeros primos:");
                bufferBool = int.TryParse(Console.ReadLine(), out numero);
                if (bufferBool == false || numero == 1)
                {
                    Console.WriteLine("Error. Reingresar el numero, debe ser mayor a 1!");
                }
                else
                {
                    bufferBool = true;
                }
            } while (bufferBool == false);
            Console.Write("Los numeros primos son: ");
            do
            {
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        acumulador++;
                    }
                }
                if (acumulador <=2)
                {
                    Console.Write("{0} ", numero);
                }
                numero--;
                acumulador = 0;
            } while (numero>1);
            Console.Read();
        }
    }
}
