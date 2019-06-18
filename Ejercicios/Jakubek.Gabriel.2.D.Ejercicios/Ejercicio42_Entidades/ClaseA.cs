using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42_Entidades
{
    public class ClaseA
    {
        public ClaseA()
        {
            try
            {
                Dividir();
            }
            catch (DivideByZeroException d)
            {

                throw d;
            }
        }

        public ClaseA(int a)
        {
            try
            {
                new ClaseA();
            }
            catch (Exception ex)
            {
                throw new UnaExcepcion("Mensaje Dividir",ex);
            }
        }

        public ClaseA(string b)
        {
            MetodoA();
        }

        public void MetodoA()
        {
            try
            {
                new ClaseA(1);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Mensaje Dividir Dividir",ex);
            }
        }

        public static void Dividir()
        {
            throw new DivideByZeroException();
        }

    }
}
