using System;

namespace H04_OO07.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            for (int i = 0; i < 5; i++) {
                bank.OpenAccount();
                bank.OpenSavingsAccount();
            }

            for (int i = 0; i < bank.Count; i++) {
                BankAccount item = bank[i]; //indexer
                //BankAccount item = bank["B0003"];

                if (item is SavingsAccount) {
                    Console.WriteLine($"{item.AccountNumber} {item.Balance} {((SavingsAccount)item).InterestRate}");
                } else {
                    Console.WriteLine($"{item.AccountNumber} {item.Balance} 0");
                }
            }

            //for (int i = 0; i < 10; i++) {
            //    BankAccount item = bank.GetAccount(i);
            //    if (item is SavingsAccount) {
            //        Console.WriteLine($"{item.AccountNumber} {item.Balance} {((SavingsAccount)item).InterestRate}");
            //    } else {
            //        Console.WriteLine($"{item.AccountNumber} {item.Balance} 0");
            //    }

            //    //SavingsAccount sa = item as SavingsAccount;
            //    //if (sa != null) {
            //    //    Console.WriteLine($"{item.AccountNumber} {item.Balance} {sa.InterestRate}");
            //    //} else {
            //    //    Console.WriteLine($"{item.AccountNumber} {item.Balance} 0");
            //    //}
            //}

            //BankAccount b2 = new BankAccount("abc");

            //nummer balance interestRate
            //B0001 100 0
            //S0002 200 2.3



            Console.ReadLine();
        }
    }
}
