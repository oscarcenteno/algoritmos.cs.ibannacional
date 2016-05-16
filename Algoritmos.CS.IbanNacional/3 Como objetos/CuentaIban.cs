namespace ComoObjetos
{
    public class CuentaIban
    {
        private string laCuentaCliente;
        private string losDosDigitosVerificadores;

        public CuentaIban(string laCuentaCliente)
        {
            losDosDigitosVerificadores = new DigitosVerificadores(laCuentaCliente).ComoTexto();
            this.laCuentaCliente = laCuentaCliente;
        }

        public string Numero
        {
            get
            {
                const string lasInicialesDelPais = "CR";

                return lasInicialesDelPais + losDosDigitosVerificadores + laCuentaCliente;
            }
        }
    }
}