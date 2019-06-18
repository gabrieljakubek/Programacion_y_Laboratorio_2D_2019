using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static int num1;
        static int min;
        static int max;
        static int suma;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.Write("Ingrese un numero: ");
                    int.TryParse(Console.ReadLine(), out num1);
                    max = num1;
                    min = num1;
                    suma += num1;
                }
                else
                {
                    Console.Write("Ingrese otro numero: ");
                    int.TryParse(Console.ReadLine(), out num1);
                    if (max < num1)
                    {
                        max = num1;
                    }
                    if (min > num1)
                    {
                        min = num1;
                    }
                    suma += num1;
                }
            }
            Console.WriteLine("El MAX es: " + max);
            Console.WriteLine("El MIN es: " + min);
            Console.WriteLine("El Promedio es: " + suma / 5);
            Console.ReadLine();
        }

    }
}

