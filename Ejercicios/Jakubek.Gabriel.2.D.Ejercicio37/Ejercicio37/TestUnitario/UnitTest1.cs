using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario_Centralita
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Metodo1()
        {
            Centralita centralita = new Centralita();
            Assert.IsNotNull(centralita.Llamadas);
        }
    }
}
