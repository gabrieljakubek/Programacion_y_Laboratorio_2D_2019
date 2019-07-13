using System;
using Controles;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Aeropuerto<Vuelo> aeropuerto = new Aeropuerto<Vuelo>();
            Archivo<Vuelo>.Guardar(aeropuerto);
            Aeropuerto<Vuelo> aeropuerto2 = Archivo<Vuelo>.Leer();
            Assert.AreEqual(aeropuerto, aeropuerto2);
        }
    }
}
