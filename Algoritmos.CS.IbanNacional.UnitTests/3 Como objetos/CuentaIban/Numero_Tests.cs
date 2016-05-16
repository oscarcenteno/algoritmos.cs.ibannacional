using ComoObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class Numero_Tests
{
    private string elResultadoEsperado;
    private string elResultadoObtenido;

    [TestMethod()]
    public void Numero_CuentaCliente_CuentaFormateada()
    {
        elResultadoEsperado = "CR1010200009007408120";

        elResultadoObtenido = new CuentaIban("10200009007408120").Numero;

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }
}