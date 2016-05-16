using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConFunciones
{
    [TestClass()]
    public class GenereElNumeroDeCuenta_Tests
    {
        private string elResultadoEsperado;
        private string elResultadoObtenido;

        [TestMethod()]
        public void GenereElNumeroDeCuenta_GeneraDosDigitos_LosMismosDigitos()
        {
            elResultadoEsperado = "CR1010200009007408120";

            elResultadoObtenido = CalculosDeCuentasIban.GenereElNumeroDeCuenta("10200009007408120");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod()]
        public void GenereElNumeroDeCuenta_GeneraUnDigito_SeAjustaADos()
        {
            elResultadoEsperado = "CR0910000073919007800";

            elResultadoObtenido = CalculosDeCuentasIban.GenereElNumeroDeCuenta("10000073919007800");

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}