namespace ConFunciones
{
    public static class CalculosDeCuentasIban
    {
        public static string GenereElNumeroDeCuenta(string laCuentaCliente)
        {
            string losDigitos;
            losDigitos = GenereLosDosDigitosVerificadores(laCuentaCliente);

            return FormateeElNumeroDeCuenta(laCuentaCliente, losDigitos);
        }

        private static string GenereLosDosDigitosVerificadores(string laCuentaCliente)
        {
            decimal elNumeroVerificador;
            elNumeroVerificador = GenereElNumeroVerificador(laCuentaCliente);

            return FormateeComoDosDigitos(elNumeroVerificador);
        }

        private static decimal GenereElNumeroVerificador(string laCuentaCliente)
        {
            decimal elRequerimientoComoNumero;
            elRequerimientoComoNumero = GenereElRequerimientoComoNumero(laCuentaCliente);

            return CalculeElNumeroVerificador(elRequerimientoComoNumero);
        }

        private static decimal GenereElRequerimientoComoNumero(string laCuentaCliente)
        {
            string elRequerimiento;
            elRequerimiento = FormateeElRequerimiento(laCuentaCliente);

            return ConviertaADecimal(elRequerimiento);
        }

        private static decimal ConviertaADecimal(string elRequerimiento)
        {
            return decimal.Parse(elRequerimiento);
        }

        private static string FormateeElRequerimiento(string laCuentaCliente)
        {
            const string elCodigoDelPais = "00";
            const string elNumeroISODelPais = "1227";

            return laCuentaCliente + elNumeroISODelPais + elCodigoDelPais;
        }

        private static decimal CalculeElNumeroVerificador(decimal elRequerimiento)
        {
            return 98 - elRequerimiento % 97;
        }

        private static string FormateeComoDosDigitos(decimal elNumeroVerificador)

        {
            if (TieneSoloUnDigito(elNumeroVerificador))
                return FormateeElNumeroPredecidoConUnCero(elNumeroVerificador);
            else
                return FormateeElNumeroComoTexto(elNumeroVerificador);
        }

        private static bool TieneSoloUnDigito(decimal elNumeroVerificador)
        {
            return elNumeroVerificador < 10;
        }

        private static string FormateeElNumeroPredecidoConUnCero(decimal elNumeroVerificador)
        {
            return $"0{elNumeroVerificador}";
        }
        
        private static string FormateeElNumeroComoTexto(decimal elNumeroVerificador)
        {
            return elNumeroVerificador.ToString();
        }

        private static string FormateeElNumeroDeCuenta(string laCuentaCliente, string losDosDigitos)
        {
            const string lasInicialesDelPais = "CR";

            return lasInicialesDelPais + losDosDigitos + laCuentaCliente;
        }
    }
}