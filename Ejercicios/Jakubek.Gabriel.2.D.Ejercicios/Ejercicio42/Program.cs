using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio42_Entidades;
namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                new ClaseA("");
            }
            catch (Exception ex)
            {
                Exception exce;
                Console.WriteLine(ex.Message);
                exce = ex;
                while (!(exce.InnerException is null))
                {
                    Console.WriteLine(exce.InnerException.Message);
                    exce = exce.InnerException;
                }
            }
            Console.ReadKey();
        }
    }
}
