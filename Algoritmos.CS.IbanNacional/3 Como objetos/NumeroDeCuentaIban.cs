namespace ComoObjetos
{
    public class NumeroDeCuentaIban
    {
        private string laCuentaCliente;
        private string losDosDigitosVerificadores;

        public NumeroDeCuentaIban(string laCuentaCliente)
        {
            losDosDigitosVerificadores = new DigitosVerificadores(laCuentaCliente).ComoTexto();
            this.laCuentaCliente = laCuentaCliente;
        }

        public string ComoTexto()
        {
            const string lasInicialesDelPais = "CR";

            return lasInicialesDelPais + losDosDigitosVerificadores + laCuentaCliente;
        }
    }
}