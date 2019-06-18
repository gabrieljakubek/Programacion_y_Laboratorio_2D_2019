using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alumno1 = new Alumno();
            alumno1.nombre = "Jorge";
            alumno1.apellido = "Cabrera";
            alumno1.legajo = 120551;
            alumno1.Estudiar(4, 9);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar() + "\r\n");

            Alumno alumno2 = new Alumno();
            alumno2.nombre = "Cacho";
            alumno2.apellido = "Castaña";
            alumno2.legajo = 120558;
            alumno2.Estudiar(6, 7);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar() + "\r\n");

            Alumno alumno3 = new Alumno();
            alumno2.nombre = "Alan";
            alumno2.apellido = "Aranda";
            alumno2.legajo = 120555;
            alumno3.Estudiar(1, 7);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar() + "\r\n");
            Console.ReadKey();
        }
    }
}
