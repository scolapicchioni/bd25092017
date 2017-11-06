using System;

namespace H04_OO07
{
    public class BankAccount {
        protected internal BankAccount(string accNumber) {
            AccountNumber = accNumber;
        }   

        public decimal Balance { get; protected set; }

        public string AccountNumber { get; }

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
