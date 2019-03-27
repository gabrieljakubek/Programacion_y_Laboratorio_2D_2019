using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio17B;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";
            string dibujo;
            Boligrafo boligrafoRojo = new Boligrafo(100, ConsoleColor.Red);
            Boligrafo boligrafoAzul = new Boligrafo(50, ConsoleColor.Blue);
            Console.ForegroundColor = boligrafoRojo.GetColor;
            boligrafoRojo.Printar(-10, out dibujo);
            Console.WriteLine(dibujo);

            Console.ForegroundColor = boligrafoAzul.GetColor;
            boligrafoAzul.Printar(-6, out dibujo);
            Console.WriteLine(dibujo);

            Console.ReadKey();
        }
    }
}
