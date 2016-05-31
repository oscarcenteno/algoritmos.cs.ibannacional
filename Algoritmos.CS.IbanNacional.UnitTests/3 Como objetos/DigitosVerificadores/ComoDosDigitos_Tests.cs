using ComoObjetos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class ComoDosDigitos_Tests
{
    private string elResultadoEsperado;
    private string elResultadoObtenido;

    [TestMethod()]
    public void ComoDosDigitos_NumeroVerificadorEsDiez_NoSePrecedeConCero()
    {
        elResultadoEsperado = "10";

        elResultadoObtenido = new DigitosVerificadores("10200009007408120").ComoTexto();

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }

    [TestMethod()]
    public void ComoDosDigitos_NumeroVerificadorEsMenorADiez_SePrecedeConCero()
    {
        elResultadoEsperado = "09";

        elResultadoObtenido = new DigitosVerificadores("10000073919007800").ComoTexto();

        Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
    }
}