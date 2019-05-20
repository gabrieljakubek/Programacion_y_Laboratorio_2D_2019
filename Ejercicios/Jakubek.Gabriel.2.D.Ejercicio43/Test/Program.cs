using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chequeo;
            Competencia competencia1 = new Competencia(52, 5, Competencia.TipoCompetencia.MotoCross);

            AutoF1 auto1 = new AutoF1(10, "Ferrari",300);
            AutoF1 auto2 = new AutoF1(14, "Mercedez", 310);
            AutoF1 auto3 = new AutoF1(15, "Renault", 300);
            AutoF1 auto4 = new AutoF1(11, "Ferrari", 300);
            AutoF1 auto5 = new AutoF1(17, "Honda", 300);
            AutoF1 auto6 = new AutoF1(10, "Ferrari", 300);
            AutoF1 auto7 = new AutoF1(85, "Ferrari", 300);

            MotoCross moto1 = new MotoCross(5, "Honda", 150);
            MotoCross moto2 = new MotoCross(6, "Mercedez", 150);
            MotoCross moto3 = new MotoCross(9, "Bugatti", 150);
            MotoCross moto4 = new MotoCross(15, "BMW", 150);
            MotoCross moto5 = new MotoCross(45, "Honda", 150);
            MotoCross moto6 = new MotoCross(5, "Honda", 150);
            MotoCross moto7 = new MotoCross(86, "Honda", 150);

            chequeo = competencia1 + auto1;
            chequeo = competencia1 + auto2;
            chequeo = competencia1 + auto3;
            chequeo = competencia1 + auto4;
            chequeo = competencia1 + auto5;
            chequeo = competencia1 + auto6;
            chequeo = competencia1 + auto7;

            chequeo = competencia1 + moto1;
            chequeo = competencia1 + moto2;
            chequeo = competencia1 + moto3;
            chequeo = competencia1 + moto4;
            chequeo = competencia1 + moto5;
            chequeo = competencia1 + moto6;
            chequeo = competencia1 + moto7;

            Console.WriteLine(competencia1.Mostrar());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            chequeo = competencia1 - auto1;
            chequeo = competencia1 - auto2;

            chequeo = competencia1 - moto1;
            chequeo = competencia1 - moto2;

            Console.WriteLine(competencia1.Mostrar());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
        }
    }
}
