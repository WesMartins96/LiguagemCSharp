using Desafio_POO_TryCatch.Entities;
using Desafio_POO_TryCatch.Entities.Exceptions;
using System;
using System.Globalization;

namespace Desafio_POO_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 
            /*Fazer um programa para ler os dados de uma conta bancária e depois realizar um
            saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
            ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
            saque da conta.*/
            Console.WriteLine("Exercicío");
            Console.WriteLine();

            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int numberAccount = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initalBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limite: ");
                double withdrawLimite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Account account = new Account(numberAccount, holder, initalBalance, withdrawLimite);
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdraw);

                Console.WriteLine(account);

            }
            catch (DomainException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }





            #endregion
        }
    }
}
