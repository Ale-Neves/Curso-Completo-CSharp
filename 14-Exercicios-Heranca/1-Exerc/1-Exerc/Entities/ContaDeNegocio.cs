namespace _1_Exerc.Entities
{
    class ContaDeNegocio : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaDeNegocio()
        { }
        public ContaDeNegocio(int numero, string titular, double saldo, double limitEmp) 
                       : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limitEmp;
        }

        public void Emprestimo(double quantia)
        {
            if(quantia <= LimiteEmprestimo)
            {
                Saldo += quantia;
            }
        }

        public override void Sacar(double quantia)
        {
            base.Sacar(quantia);
            Saldo -= 5.00;
        }
    }
}
