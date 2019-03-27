using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Rectangulo
    {
        #region Atributos
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        #endregion

        #region Constructores
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX, vertice1.GetY);
            this.vertice4 = new Punto(vertice1.GetX, vertice3.GetY);
        }
        #endregion
        
        #region Metodo

        #endregion
    }
}
