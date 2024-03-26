using POO_Heranca.Entities;
using System;

namespace POO_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "Beatriz", 0.0, 200.0);
            Account account3 = new SavingsAccount(1004, "Gael", 0.0, 0.01);

            // DOWNCASTING  
            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.0);

            //BusinessAccount account5 = (BusinessAccount)account3; erro de casting distapa em tempo de execução


            // IS -> verificar se é de um tipo ou de outro
            if (account3 is BusinessAccount)
            {
                //BusinessAccount account5 = (BusinessAccount)account3;
                //AS -> outra forma de fazermos o casting
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if (account3 is SavingsAccount)
            {
                //SavingsAccount account5 = (SavingsAccount)account3;
                //AS -> outra forma de fazermos o casting
                SavingsAccount account5 = account3 as SavingsAccount;
                account5.UpdateBalance();
                Console.WriteLine("Update!");
            }




        }
    }
}
