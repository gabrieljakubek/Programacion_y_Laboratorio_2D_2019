using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        private int horasVuelo;
        private Thread vuelo;

        public EstadoVuelo Estado
        {
            get
            {
                if (Object.Equals(vuelo,null))
                {
                    return EstadoVuelo.Programado;
                }
                else if (vuelo.IsAlive)
                {
                    return EstadoVuelo.Volando;
                }
                else
                {
                    return EstadoVuelo.Aterrizado;
                }
            }
        }

        public int HorasVuelo { get { return this.horasVuelo; } }

        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }

        public void Despegar()
        {
            vuelo = new Thread(Volar);
            vuelo.Start();
        }

        public void Estrellar()
        {
            if (vuelo.IsAlive)
            {
                vuelo.Abort();
            }
        }

        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
                Thread.Sleep(100);
                horasRestantes --;
                porcentajeCompletado= this.ReporteDeEstado(this.horasVuelo, horasRestantes);
            }
        }

        public event ReporteDeEstado ReporteDeEstado;
    }

    public enum EstadoVuelo
    {
        Programado,
        Volando,
        Aterrizado
    }
}
