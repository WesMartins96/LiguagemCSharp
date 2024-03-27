using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
            
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Usando override para sobrescrever o deposito de Account.cs
        //Podemos usar a palavra base, reaproveitando a operação da superclasse (Account.cs) e adicionar novas coisas, conforme exemplo abaixo:
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
