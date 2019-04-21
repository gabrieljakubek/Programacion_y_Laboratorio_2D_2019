using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{

    class PuestoAtencion
    {
        #region
        public enum Puesto
        {
            Caja1,
            Caja2
        }
        #endregion

        #region Atributos
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region Propiedades
        public static int NumeroActual
        {
            get
            {
                numeroActual++;
                return numeroActual;
            }
        }
        #endregion

        #region Constructores
        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }
        #endregion

        #region Metodos
        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(10000);
            return true;
        }
        #endregion
    }
}
