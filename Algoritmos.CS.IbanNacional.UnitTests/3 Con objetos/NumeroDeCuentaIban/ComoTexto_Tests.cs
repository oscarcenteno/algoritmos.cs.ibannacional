using ConObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class Numero_Tests
{
    private string elResultadoEsperado;
    private string elResultadoObtenido;

    [TestMethod()]
    public void ComoTexto_NumeroVerificadorEsDiez_NoSePrecedeConCero()
    {
        elResultadoEsperado = "CR0910000073919007800";

        elResultadoObtenido = new NumeroDeCuentaIban("10000073919007800").ComoTexto();

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void ComoTexto_NumeroVerificadorEsMenorADiez_SePrecedeConCero()
    {
        elResultadoEsperado = "CR1010200009007408120";

        elResultadoObtenido = new NumeroDeCuentaIban("10200009007408120").ComoTexto();

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }
}