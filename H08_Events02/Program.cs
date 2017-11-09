using System;

namespace H08_Events02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount("A123");

            ResponsibleOwner Wesley = new ResponsibleOwner();
            IrresponsibleOwner Yolanthe = new IrresponsibleOwner();

            Wesley.Account = b1;
            Yolanthe.Account = b1;

            b1.SaldoDecreased += Wesley.Panic;
            b1.SaldoChanged += refreshScreen;

            Yolanthe.UseBankAccount();

            BankAccount b2 = new BankAccount("B345");
            b2.SaldoChanged += refreshScreen;
            b2.Withdraw(23);

            Console.ReadLine();
        }

        static void refreshScreen(BankAccount source, decimal newSaldo) {
            Console.WriteLine(source.AccountNumber + " !!!! " + newSaldo);
        }
    }
}
