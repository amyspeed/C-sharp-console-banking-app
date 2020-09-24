using System;
using banking_class_library;

namespace banking_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            account.MakeWithdrawal(5, DateTime.Now, "Coffee");
            account.MakeWithdrawal(2, DateTime.Now, "Diet Coke");
            account.MakeWithdrawal(3, DateTime.Now, "Coffee");
            account.MakeWithdrawal(4, DateTime.Now, "Coffee");
            account.MakeWithdrawal(5, DateTime.Now, "Coffee");
            account.MakeWithdrawal(6, DateTime.Now, "Coffee");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(7, DateTime.Now, "Coffee");
            account.MakeWithdrawal(8, DateTime.Now, "Coffee");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

        }
    }
}
