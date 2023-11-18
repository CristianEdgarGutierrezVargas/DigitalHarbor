using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BD_DigitalHarbor;
using BD_DigitalHarbor.CRUD;

namespace UnitTestDigitalHarbor
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestActividad()
        {
            CActividades cActividades = new CActividades();
            cActividades.CreateActividad(DateTime.Now,DateTime.Now.AddDays(1),"Probando el guardado");
            Assert.IsTrue(true);
        }
    }
}
