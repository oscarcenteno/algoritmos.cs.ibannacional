namespace ConObjetos
{
    public class NumeroVerificador
    {
        private decimal elRequerimiento;

        public NumeroVerificador(string laCuentaCliente)
        {
            elRequerimiento = new Requerimiento(laCuentaCliente).ComoNumero();
        }

        public decimal ComoNumero()
        {
            return 98 - (elRequerimiento % 97);
        }
    }
}