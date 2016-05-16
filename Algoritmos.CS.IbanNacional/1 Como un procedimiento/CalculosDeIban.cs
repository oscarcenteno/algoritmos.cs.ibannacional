namespace ComoUnProcedimiento
{
    public static class CalculosDeCuentasIban
    {
        public static string GenereElNumeroDeCuentaIBAN(string laCuentaCliente)
        {
            const string elNumeroISODelPais = "1227";
            const string elCodigoDelPais = "00";
            string elRequerimiento;
            elRequerimiento = laCuentaCliente + elNumeroISODelPais + elCodigoDelPais;

            decimal elRequerimientoComoNumero;
            elRequerimientoComoNumero = decimal.Parse(elRequerimiento);

            decimal elNumeroVerificador;
            elNumeroVerificador = 98 - elRequerimientoComoNumero % 97;

            string losDosDigitosVerificadores;
            if (elNumeroVerificador < 10)
                losDosDigitosVerificadores = $"0{elNumeroVerificador}";
            else
                losDosDigitosVerificadores = elNumeroVerificador.ToString();

            const string lasInicialesDelPais = "CR";
            return lasInicialesDelPais + losDosDigitosVerificadores + laCuentaCliente;
        }
    }
}