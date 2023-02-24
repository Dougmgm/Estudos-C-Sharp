using Herança.Entities;
using System;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500.00);

            // UPCASTING: conversão da subclasse para a superclasse

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01);

            //DOWNCASTING: conversão da superclasse para a subclasse

            BusinessAccount acc4 = (BusinessAccount)acc2; //Casting entre os parênteses
            acc4.Loan(100.00);

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.00);
                System.Console.WriteLine("Loan");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                System.Console.WriteLine("Update");
            }
            */

            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Ana", 500.00, 0.01);

            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
