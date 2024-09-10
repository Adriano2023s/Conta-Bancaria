using System;

namespace ContaBancaria
{
    internal class Conta
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double NumeroConta { get; set; }
        public double Saldo { get; private set; }

        public Conta(string nome, string cpf, double numeroConta, double saldoInicial = 0)
        {
            Nome = nome;
            CPF = cpf;
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public Conta()
        {
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public bool Sacar(double valor)
        {
            if (valor > 0)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }
    }
}
