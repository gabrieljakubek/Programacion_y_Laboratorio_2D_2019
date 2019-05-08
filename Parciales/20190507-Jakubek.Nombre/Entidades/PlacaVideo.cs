using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo : Periferico
    {
        #region Atributos
        private int ramMB;
        #endregion

        #region Constructor
        public PlacaVideo(string marca, string modelo, int ramMB) : base(marca, modelo, EConector.PCIExpress)
        {
            this.ramMB = ramMB;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Retorna Los datos de la Placa de Video
        /// </summary>
        /// <returns></returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("PLACA DE VIDEO {0}\r\n",(string)this);
            sb.AppendLine("Memoria: " + this.ramMB + "MB");
            return sb.ToString();
        }
        #endregion
    }
}
