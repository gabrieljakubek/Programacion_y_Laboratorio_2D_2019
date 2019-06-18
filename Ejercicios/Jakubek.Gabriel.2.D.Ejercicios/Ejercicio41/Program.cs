using Ejercicio41_Entidades;
using System;

namespace Ejercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº41 Guía 2019";
            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            string mensaje = "";
            try
            {
                c += l1;
                c += l2;
                c += l3;
                c += l4;
                c += l4;
            }
            catch (CentralitaException excepcion)
            {
                mensaje = excepcion.Message;
            }

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            if (mensaje != "")
            {
                Console.WriteLine(mensaje);
            }
            Console.ReadKey();
        }
    }
}
