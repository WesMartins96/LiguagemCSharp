using POO_Classes_Abstratas.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace POO_Classes_Abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //mesmo Account sendo uma classe abstrata ela pode ser colocada ser instaciada como lista
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Wesley", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Gael", 500.0, 500.0));

            double sum = 0.0;
            foreach (var acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (var acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach (var acc in list)
            {
                Console.WriteLine("Update balance for account " + acc.Number + ": " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
