using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static int ingreso;
        static bool auxBool;
        static bool anoBisiesto = false;
        static int diaNacimiento;
        static int mesNAcimiento;
        static int anoNacimiento;
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";
            do
            {
                Console.Write("Ingrese su año de nacimiento: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso <= 0)
                {
                    Console.WriteLine("Error. Reingresar el año!");
                }
                else
                {
                    anoNacimiento = ingreso;
                    if (anoNacimiento % 4 == 0 || anoNacimiento % 100 == 0 && anoNacimiento % 400 == 0)
                    {
                        anoBisiesto = true;
                    }
                        auxBool = true;
                }
            } while (!auxBool);
        }
    }
}
