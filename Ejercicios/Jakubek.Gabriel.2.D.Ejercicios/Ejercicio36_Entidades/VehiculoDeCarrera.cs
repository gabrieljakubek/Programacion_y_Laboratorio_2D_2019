using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio36_Entidades
{
    public class VehiculoDeCarrera
    {
        #region Atributos
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        #endregion

        #region Propiedades
        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
               this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion

        #region Constructor
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Metodos
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero: " + this.numero);
            sb.AppendLine("Escuderia: "+this.escuderia);
            sb.AppendLine("En competencia: " + this.enCompetencia);
            sb.AppendLine("Vueltas restantes: " + this.vueltasRestantes);
            sb.AppendLine("Cantidad de combustible: " + this.cantidadCombustible);
            return sb.ToString();
        }
        #endregion
    }
}
