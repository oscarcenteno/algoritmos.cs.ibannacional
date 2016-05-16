using ComoObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class ComoNumero_Tests
{
    private decimal elResultadoEsperado;
    private decimal elResultadoObtenido;

    [TestMethod()]
    public void ComoNumero_CualquierCuentaCliente_NumeroVerificadorComoUnNumeroEntero()
    {
        elResultadoEsperado = 10;

        elResultadoObtenido = new NumeroVerificador("10200009007408120").ComoNumero();

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }
}