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
        static int mesNacimiento;
        static int anoNacimiento;
        static int diasTotales;
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
            auxBool = false;
            do
            {
                Console.Write("Ingrese su mes de nacimiento: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso <= 0 || ingreso > 12)
                {
                    Console.WriteLine("Error. Reingresar el mes!");
                }
                else
                {
                    mesNacimiento = ingreso;
                    auxBool = true;
                }
            } while (!auxBool);
            auxBool = false;
            do
            {
                Console.Write("Ingrese su dia de nacimiento: ");
                int.TryParse(Console.ReadLine(), out ingreso);
                if (ingreso <= 0 || (mesNacimiento == 1 || mesNacimiento == 3 || mesNacimiento == 5
                    || mesNacimiento == 7 || mesNacimiento == 8 || mesNacimiento == 10
                    || mesNacimiento == 12) && ingreso > 31
                    || mesNacimiento == 2 && anoBisiesto == false && ingreso > 28
                    || mesNacimiento == 2 && anoBisiesto == true && ingreso > 29
                    || (mesNacimiento == 4 || mesNacimiento == 6 || mesNacimiento == 9
                    || mesNacimiento == 11) && ingreso > 30)
                {
                    Console.WriteLine("Error. Reingresar el dia!");
                }
                else
                {
                    diaNacimiento = ingreso;
                    auxBool = true;
                }
            } while (!auxBool);
            for (int i = mesNacimiento; i <= 12; i++)
            {
                diasTotales += DateTime.DaysInMonth(anoNacimiento, i);
            }
            diasTotales -= diaNacimiento;
            for (int j = anoNacimiento + 1; j < DateTime.Now.Year; j++)
            {
                for (int k = 1; k <= 12; k++)
                {
                    diasTotales += DateTime.DaysInMonth(j, k);
                }
            }
            for (int h = 1; h <= DateTime.Now.Month; h++)
            {
                diasTotales += DateTime.DaysInMonth(DateTime.Now.Year, h);
            }
            Console.Write("Usted a vivido {0} dias", diasTotales);
            Console.ReadKey();
        }
    }
}
