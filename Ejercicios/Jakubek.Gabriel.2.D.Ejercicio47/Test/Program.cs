using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneFutbol=new Torneo<EquipoFutbol>("Torneo de futbol Cebollitas");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("Torneo de basket Ginobilli for Ever");

            EquipoFutbol futbol1 = new EquipoFutbol("Quilmes Alfa", new DateTime(1991,12,16));
            EquipoFutbol futbol2 = new EquipoFutbol("Banfield 2", new DateTime(1998, 05, 16));
            EquipoFutbol futbol3 = new EquipoFutbol("River Plata", new DateTime(1968, 08, 16));

            EquipoBasquet basquet1 = new EquipoBasquet("Lakers", new DateTime(1957, 12, 16));
            EquipoBasquet basquet2 = new EquipoBasquet("Bulls", new DateTime(1968, 06, 16));
            EquipoBasquet basquet3 = new EquipoBasquet("Spurs", new DateTime(1970, 05, 16));

            torneFutbol += futbol1;
            torneFutbol += futbol2;
            torneFutbol += futbol3;

            torneoBasquet += basquet1;
            torneoBasquet += basquet2;
            torneoBasquet += basquet3;

            Console.WriteLine(torneFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneFutbol.JugarPartido);
            Console.WriteLine(torneFutbol.JugarPartido);
            Console.WriteLine(torneFutbol.JugarPartido);

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadLine();
        }
    }
}
