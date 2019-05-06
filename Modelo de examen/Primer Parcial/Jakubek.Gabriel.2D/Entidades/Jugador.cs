using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        #region Atributos
        private float altura;
        private float peso;
        private Posicion posicion;
        #endregion

        #region Propiedades
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }
        #endregion

        #region Constructores
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.altura = altura;
            this.peso = peso;
            this.posicion = posicion;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Retorna los datos del jugador
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.AppendLine("Altura: " + this.altura);
            sb.AppendLine("Peso: " + this.peso);
            sb.AppendFormat("Posicion: {0} \n\n",this.posicion);
            return sb.ToString();
        }

        /// <summary>
        /// Comprueba que el jugador cumpla con los requisitos fisicos establesidos
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float IMC = this.peso / (this.altura * this.altura);
            if (IMC >= 18.5 && IMC <= 25)
            {
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Comprueba que el jugador cumpla con los requisitos establesidos para ser apto
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad<40 && this.ValidarEstadoFisico())
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
