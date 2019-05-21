using System;
using Ejercicio41_Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCentralita
{
    [TestClass]
    public class TestCentralita
    {
        [TestMethod]
        public void TestInstancia()
        {
            Centralita centralita = new Centralita();
            Assert.IsNotNull(centralita.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestIgualLlamadaLocal()
        {
            Centralita c = new Centralita("Fede Center");
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);

            //try
            //{
            c += l1;
            c += l3;
            c += l1;
            //}
            //catch (Exception excepcion)
            //{
            //    Assert.IsInstanceOfType(excepcion, typeof(CentralitaException));   
            //}
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestIgualLlamadaProvincial()
        {
            Centralita c = new Centralita("Fede Center");
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            //try
            //{
            c += l2;
            c += l4;
            c += l4;
            //}
            //catch (Exception excepcion)
            //{
            //    Assert.IsInstanceOfType(excepcion, typeof(CentralitaException));   
            //}
        }

        [TestMethod]
        public void TestLlamadasIguales()
        {
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            //try
            //{
            Assert.AreNotEqual(l1, l2);
            Assert.AreEqual(l1, l3);
            Assert.AreNotEqual(l2, l3);
            Assert.AreEqual(l2, l4);
            //}
            //catch (Exception excepcion)
            //{
            //    Assert.IsInstanceOfType(excepcion, typeof(CentralitaException));   
            //}
        }
    }
}
