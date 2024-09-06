namespace ContaBancaria
{
    internal class Conta
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public double LimiteNegativo { get; private set; }

        public Conta(string nome, string cpf, double numeroconta, double limitenegativo)
        {
            Nome = nome;
            CPF = cpf;
            NumeroConta = numeroconta;
            Saldo = 0;
            LimiteNegativo = limitenegativo;
        }

        public void Depozitar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0 && valor <= LimiteNegativo)
            {
                Saldo -= valor;
                return true;
            }
            return false;
            }

        public void ExibirLimiteNegativo(double valorNegativo)
        {
            LimiteNegativo -= valorNegativo;
        }
    }
}
