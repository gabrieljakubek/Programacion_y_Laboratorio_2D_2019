using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static int maximo = 10000;
        static int i;
        static int j;
        static int mitad;
        static int total =0;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            Console.Write("Los primeros 4 numeros perfectos son: ");
            for (i=2;i<maximo;i++)
            {
                mitad = i / 2;
                for(j=1;j<=mitad;j++)
                {
                    if(i%j==0)
                    {
                        total += j;
                    }
                }
                if (total == i)
                {
                    Console.Write("{0} ", i);
                }
                total = 0;
            }
            Console.ReadLine();
        }
    }
}
