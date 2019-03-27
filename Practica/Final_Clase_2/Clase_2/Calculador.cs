using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Calculador
    {
        #region Atributos
        private int _acumulador;
        #endregion

        #region Metodo
        public void acumulador(string binario)
        {
            this._acumulador += Conversor.BinarioEntero(binario);
        }
        private Calculador()
        {
            this._acumulador = 0;
        }
        public string getResultadoBinario()
        {
            string retorno=Conversor.EnteroBinario(this._acumulador);
            return retorno;
        }

        public int getResultadoEntero()
        {
            int retorno = this._acumulador;
            return retorno;
        }
        #endregion
    }
}
