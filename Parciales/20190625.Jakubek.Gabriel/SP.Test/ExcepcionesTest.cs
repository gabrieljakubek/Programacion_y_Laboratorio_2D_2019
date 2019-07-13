using System;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SP.Test
{
    [TestClass]
    public class ExcepcionesTest
    {
        [TestMethod]
        [ExpectedException(typeof(EmisorException))]
        public void EmisorException()
        {
            EmisorDeEmails emisor = new EmisorDeEmails("asdasd", EProducto.SQLDatabase, "asdasd");
            emisor.EnviarMensaje();
        }

        [TestMethod]
        [ExpectedException(typeof(WhatsappException))]
        public void WhatsappException()
        {
            EmisorDeWhatsapp emisor = new EmisorDeWhatsapp("asd", EProducto.MonitoringApp, 12123123);
            emisor.EnviarMensaje();
        }
    }
}
