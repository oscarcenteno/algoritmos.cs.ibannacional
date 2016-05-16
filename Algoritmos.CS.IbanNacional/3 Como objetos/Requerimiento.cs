namespace ComoObjetos
{
    public class Requerimiento
    {
        private string elRequerimiento;

        public Requerimiento(string laCuentaCliente)
        {
            const string elCodigoDelPais = "00";
            const string elNumeroISODelPais = "1227";

            elRequerimiento = laCuentaCliente + elNumeroISODelPais + elCodigoDelPais;
        }

        public decimal ComoNumero()
        {
            return decimal.Parse(elRequerimiento);
        }
    }
}