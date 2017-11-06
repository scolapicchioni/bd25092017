using System;

namespace H04_OO07
{
    public class BankAccount {
        private decimal balance;

        public decimal Balance { get; protected set; }

        private string accountNumber;

        public string AccountNumber { get; set; }

        public decimal Deposit(decimal amount) {
            if (amount < 0)
                amount = 0;
            Balance += amount;
            return amount;
        }

        public virtual decimal Withdraw(decimal amount) {
            if (amount < 0)
                amount = 0;
            Balance -= amount;
            return amount;
        }

    }
}
