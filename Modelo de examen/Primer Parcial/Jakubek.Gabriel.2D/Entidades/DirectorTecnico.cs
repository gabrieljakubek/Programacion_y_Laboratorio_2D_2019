using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {

        #region Atributos
        private int añosExperiencia;
        #endregion

        #region Propiedades
        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set {this.añosExperiencia = value; }
        }
        #endregion

        #region Constructores
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Años de Experiencia: " + añosExperiencia +"\r\n");
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad<65 && this.añosExperiencia >=2)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
