using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18
{
    class Punto
    {
        #region
        private int x;
        private int y;
        #endregion

        #region Metodos
        public int GetX
        {
            get
            {
                return this.x;
            }
        }
        public int GetY
        {
            get
            {
                return this.y;
            }
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion
    }
}
