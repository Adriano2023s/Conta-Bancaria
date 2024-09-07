using System;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            Console.WriteLine("Digite o seu nome \n");
            conta.Nome = Console.ReadLine();

            Console.WriteLine("Digite o seu CPF \n");
            conta.CPF = Console.ReadLine();

            Console.WriteLine("Digite o número da conta \n");
            conta.NumeroConta = double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do cliente: {conta.Nome}, {conta.CPF}, número da conta: {conta.NumeroConta}");
            Console.Clear();

            Console.WriteLine("O primeiro depósito não é obrigatório. Escolha se deseja depositar ou não.");
            Console.WriteLine("Deseja fazer um depósito? Digite 's' para sim, 'n' para não.");
            string opcao = Console.ReadLine();

            if (opcao == "s")
            {
                Console.WriteLine("Informe o valor do depósito:");
                double valorDeposito = double.Parse(Console.ReadLine());
                conta.Depozitar(valorDeposito);
            }
            else
            {
                Console.WriteLine("Ok, conta aberta sem depósito.");
            }

            Console.WriteLine($"O valor atual da sua conta é de: {conta.Saldo}");

            Console.WriteLine("Deseja fazer um saque? Digite 's' para sim, e 'n' para não.");
            opcao = Console.ReadLine();

            if (opcao == "s")
            {
                Console.WriteLine("Informe o valor que você deseja sacar:");
                double valorSaque = double.Parse(Console.ReadLine());
                bool saqueRealizado = conta.Sacar(valorSaque);
                Console.WriteLine("Saque realizado!");

                if (conta.Saldo < 0)
                {
                    Console.WriteLine($"Seu saldo está negativo. {conta.Saldo}");
                }
            }
        }
    }
}
