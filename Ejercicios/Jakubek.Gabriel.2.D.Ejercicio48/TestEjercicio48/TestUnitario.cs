using System;
using Contabilidad;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEjercicio48
{
    [TestClass]
    public class TestUnitario
    {
        [TestMethod]
        public void TestMethod1()
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

        }
    }
}
