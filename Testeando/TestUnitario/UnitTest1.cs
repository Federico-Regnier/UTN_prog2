using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testeando;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanciaEstacionamiento()
        {
            Estacionamiento est1 = new Estacionamiento();
            Assert.IsNotNull(est1);

        }

        [TestMethod]
        public void ListadoInstanciado()
        {
            Estacionamiento est1 = new Estacionamiento();
            Assert.IsNotNull(est1.listaVehiculos);
        }
    }
}
