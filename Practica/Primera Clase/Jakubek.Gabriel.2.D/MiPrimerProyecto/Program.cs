using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
        //static int miEntero;
        //static double miDouble = 20;
        //static string miPalabra = "0";
        //static bool miBool;
        static int num1;
        static float num2;
        static int opcion;
        static string buffer;
        static bool bufferBool;
        static float bufferFloat;
        static bool continuar = true;


        static void Main(string[] args)
        {
            //miEntero = 5;
            //miEntero = miDouble;
            //miDouble = miEntero;
            //miEntero = (int)miDouble;
            //miEntero = (int)miPalabra;
            //miPalabra = miBool.ToString();
            //miEntero = int.Parse(miPalabra);
            //int.TryParse(miPalabra, out miEntero);
            //System.Console.WriteLine("Helllo world!!!!");
            //ConsoleKeyInfo cki = System.Console.ReadKey();
            //Console.WriteLine(cki.Key);
            //Console.ReadLine();
            do
            {
                Console.Write("Ingrese un numero: ");
                bufferBool = int.TryParse(Console.ReadLine(), out num1);
                while (bufferBool != true)
                {
                    Console.Write("Reingrese un numero: ");
                    bufferBool = int.TryParse(Console.ReadLine(), out num1);
                }
                Console.Write("Otro un numero: ");
                bufferBool = float.TryParse(Console.ReadLine(), out num2);
                while (bufferBool != true)
                {
                    Console.Write("Reingrese un numero: ");
                    bufferBool = float.TryParse(Console.ReadLine(), out num2);
                }
                Console.WriteLine("Ingrese una opcion:" +
                                 "\nOpc1: Suma" +
                                 "\nOpc2: Resta" +
                                 "\nOpc3: Divicion" +
                                 "\nOpc4: Multiplicacion");
                bufferBool = int.TryParse(Console.ReadLine(), out opcion);
                if(bufferBool!=true)
                {
                    Console.WriteLine("Se ingreso solamente numeros!!");
                }
                else if ( num2 == 0 && opcion == 3)
                {
                    Console.WriteLine("Se ingreso un 0!!");
                    
                }
                else
                {
                    bufferFloat = Calcular(opcion, num1, num2);
                    Console.WriteLine("{0,0:#.##}", bufferFloat);
                }
                Console.WriteLine("Desea continuar? S/N");
                buffer = Console.ReadLine();
                if (buffer.ToUpper() != "S")
                {
                    continuar = false;
                }
                else
                {
                    continuar = true;
                }

            } while (continuar == true);
        }

        static float Calcular(int opcion, int num1, float num2)
        {
            float retorno;
            switch (opcion)
            {
                case 1:
                    retorno = (num1 + num2);
                    break;
                case 2:
                    retorno = (num1 - num2);
                    break;
                case 3:
                       retorno = (num1 / num2);
                    break;
                case 4:
                    retorno = (num1 * num2);
                    break;
                default:
                    retorno = 0;
                    break;
            }
            return retorno;
        }
    }
}
