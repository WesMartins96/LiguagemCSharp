using System;
using System.Drawing;
using System.Globalization;

namespace Desafio_POO_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1 
            /*
             * Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, e o 
             valor de depósito inicial que o ttular depositou ao abrir a conta. Este valor de depósito inicial, entretanto, é opcional, ou seja:
            se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, zero
            
             Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado (pois
            uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
            
             Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos,
            e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não
            for suficiente para realizar o saque e/ou pagar a taxa.
            
             Você deve fazer um programa que realize o cadastro de uma conta. dando opção para que seja ou não informado o valor de depósito inicial. Em seguida,
            realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.
             */
            Console.WriteLine("--- Exercicio 1 ---");

            var culture = CultureInfo.InvariantCulture;
            Conta conta = new Conta();

            Console.Write("Entre o número da conta: ");
            conta.NumeroConta = Console.ReadLine();

            Console.Write("Entre o titular da conta: ");
            conta.Titular = Console.ReadLine();

            Console.Write("Haverá o valor de depósito inicial (s/n)? ");

            string entrada = Console.ReadLine();
            entrada.ToLower();
            double deposito;
            if (entrada == "s")
            {
                conta.Deposito(conta.Saldo);
                Console.Write("Entre com o valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), culture);
                conta.Deposito(deposito);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), culture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados Atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor de saque: ");
            double saque = double.Parse(Console.ReadLine(), culture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            #endregion
        }
    }
}
