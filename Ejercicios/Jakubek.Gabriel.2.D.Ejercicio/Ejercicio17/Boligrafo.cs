using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17B
{
    class Boligrafo
    {
        #region Atributos
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        #region Propiedades
        public ConsoleColor GetColor
        {
            get
            {
                return this.color;
            }
        }

        public short GetTinta
        {
            get
            {
                return this.tinta;
            }
        }
        #endregion

        #region
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.SetTinta(tinta);
            this.color = color;
        }
        #endregion

        #region Metodos
        private void SetTinta(int tinta)
        {
            if (this.tinta >= 0 && this.tinta <= cantidadTintaMaxima)
            {
                if (tinta < 0 && this.tinta - tinta >= 0)
                {
                    this.tinta += (short)tinta;
                }
                else if (tinta > 0 && tinta + this.tinta <= cantidadTintaMaxima)
                {
                    this.tinta += (short)tinta;
                }
            }
        }

        private string TintaRestante()
        {
            string dibujo = "";
            for (int i = 0; i < this.tinta; i++)
            {
                dibujo += "*";
            }
            this.SetTinta(-(this.GetTinta));
            return dibujo;
        }

        public void Recarga()
        {
            this.SetTinta(100);
        }

        public bool Printar(short gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            if (this.tinta - gasto >= 0)
            {
                for (int i = 0; i < -gasto; i++)
                {
                    dibujo += "*";
                }
                this.SetTinta((short)gasto);
                retorno = true;
            }
            else if (this.tinta - gasto < 0)
            {
                TintaRestante();
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
