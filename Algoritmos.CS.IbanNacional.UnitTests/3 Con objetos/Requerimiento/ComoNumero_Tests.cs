using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Requerimiento_Tests
{
    [TestClass()]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;

        [TestMethod()]
        public void ComoNumero_CualquierCuentaCliente_ElRequerimientoComoUnNumeroEntero()
        {
            elResultadoEsperado = 10200009007408120122700m;

            elResultadoObtenido = new Requerimiento("10200009007408120").ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}