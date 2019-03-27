using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Jorge", "Cabrera", 120551);
            alumno1.Estudiar(4, 9);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar()+ "\r\n");

            Alumno alumno2 = new Alumno("Cacho", "Castaña", 120558);
            alumno2.Estudiar(6, 7);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar()+ "\r\n");

            Alumno alumno3 = new Alumno("Alan", "Aranda", 120555);
            alumno3.Estudiar(1, 7);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar()+ "\r\n");
            Console.ReadKey();
        }
    }
}
