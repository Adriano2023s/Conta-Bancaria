using System;

namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            bool loopMenu = true;

            while (loopMenu)
            {
                Console.WriteLine("Iniciando o sistema");
                Console.WriteLine("1: Abrir conta com depósito");
                Console.WriteLine("2: Abrir conta sem depósito");
                Console.WriteLine("3: Efetuar depósito");
                Console.WriteLine("4: Efetuar saque");
                Console.WriteLine("5: Exibir dados do cliente");
                Console.WriteLine("6: Sair");
                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Informe o nome do cliente:");
                        conta.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o CPF do titular da conta:");
                        conta.CPF = Console.ReadLine();

                        Console.WriteLine("Informe o número da conta que deseja cadastrar:");
                        conta.NumeroConta = double.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o valor do depósito inicial:");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito);

                        Console.WriteLine("Conta criada com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Informe o nome do titular da conta:");
                        conta.Nome = Console.ReadLine();

                        Console.WriteLine("Informe o CPF do titular da conta:");
                        conta.CPF = Console.ReadLine();

                        Console.WriteLine("Informe o número da conta que deseja cadastrar:");
                        conta.NumeroConta = double.Parse(Console.ReadLine());

                        Console.WriteLine("Conta criada com sucesso!");
                        break;

                    case 3:
                        Console.WriteLine("Informe o valor que deseja depositar:");
                        double valorDeposito2 = double.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito2);

                        Console.WriteLine("Seu saldo é de:");
                        conta.ExibirSaldo();
                        break;

                    case 4:
                        Console.WriteLine("Informe o valor do saque:");
                        double valorSaque = double.Parse(Console.ReadLine());
                        bool saqueRealizado = conta.Sacar(valorSaque);

                        if (saqueRealizado)
                        {
                            Console.WriteLine("Saque realizado com sucesso!");
                        }

                        Console.WriteLine("Seu saldo é de:");
                        conta.ExibirSaldo();
                        break;

                    case 5:
                        Console.WriteLine("Dados do cliente:");
                        Console.WriteLine($"Nome do cliente: {conta.Nome}");
                        Console.WriteLine($"CPF: {conta.CPF}");
                        Console.WriteLine($"Número da conta: {conta.NumeroConta}");
                        Console.WriteLine($"Saldo atual: {conta.Saldo}");
                        break;

                    case 6:
                        loopMenu = false;
                        Console.WriteLine("Saindo do sistema...");
                        break;

                }
            }
        }
    }
}
