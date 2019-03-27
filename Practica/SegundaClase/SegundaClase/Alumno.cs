using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundaClase
{
    class Alumno
    {
        static Random random;
        public static string colegio;
        #region Atributos
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;
        #endregion

        #region Constructor
        static Alumno()
        {
            random = new Random(DateTime.Now.Millisecond);
            colegio = "UTN";
        }
        public Alumno(string nombreA, string apellidoA, int legajoA)
        {
            nombre = nombreA;
            apellido = apellidoA;
            legajo = legajoA;
        }
        #endregion

        #region Metodos
        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = random.Next(1, 10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public string Mostrar()
        {
            string retorno = "";
            retorno += "Nombre: " + nombre + "\r\nApellido: " + apellido + "\r\nLegajo: " + legajo
                + "\r\n" + (this._notaFinal == -1 ? "Alumno desaprobado" : "Nota Final: " + this._notaFinal);
            //if (_notaFinal != -1)
            //{
            //    retorno += "\r\nNota Final: " + this._notaFinal;
            //}
            //else
            //{
            //    retorno += "\r\nAlumno desaprobado";
            //}
            return retorno;
        }
        #endregion
    }
}
