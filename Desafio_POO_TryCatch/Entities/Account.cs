using Desafio_POO_TryCatch.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_POO_TryCatch.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
            
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }


        public void Deposit(double account)
        {
            Balance += account;
        }

        public void Withdraw(double account)
        {
            if (account > Balance)
            {
                throw new DomainException("Saque indisponivel para esta operação [Valor de saque menor do que o saldo]");
            }
            if (account > WithdrawLimit)
            {
                throw new DomainException("Saque indisponivel para esta operação [Valor do saque excede o valor limite da conta]");
            }

            Balance -= account;
        }

        public override string ToString()
        {
            return string.Format("New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
