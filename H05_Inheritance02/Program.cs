using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance02 {
    class Program {
        static void Main(string[] args) {
            BankAccount b1 = new BankAccount("aaa");

            b1.Deposit(100);
            Console.WriteLine(b1.Saldo);

            decimal withdrawn = b1.Withdraw(1000);
            Console.WriteLine(b1.Saldo);
            Console.WriteLine($"Withdrawn: {withdrawn}; Saldo == {b1.Saldo}");

            Console.WriteLine("************************");

            GoldBankAccount b2 = new GoldBankAccount("aaa");

            b2.Deposit(100);
            Console.WriteLine(b2.Saldo);

            //withdrawn = b2.Withdraw(1000);
            //Console.WriteLine($"Withdrawn: {withdrawn}; Saldo == {b2.Saldo}");

            UseBankAccount(b2);

            Console.ReadLine();

            //b1._saldo = 100000000000000000;
        }

        private static void UseBankAccount(BankAccount toUse) {
            //decimal withdrawn = 0;
            //GoldBankAccount gba = toUse as GoldBankAccount;
            //if (gba != null) {
            //    withdrawn = gba.Withdraw(1000);
            //} else {
            decimal withdrawn = toUse.Withdraw(1000);
            //}
            Console.WriteLine($"Withdrawn: {withdrawn}; Saldo == {toUse.Saldo}");
        }
    }
}
