using System;
using System.Collections.Generic;
using System.Text;

namespace H04_OO06
{
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance { get; private set; }

        private string accountNumber;

        public string AccountNumber { get; set; }

        private double interestRate;
        public double InterestRate {
            get {
                return interestRate;
            }
            set {
                if (Type == BankAccountType.Savings) {
                    if (value < -20.0 || value > 20.0)
                        throw new ArgumentOutOfRangeException();
                    interestRate = value;
                } else {
                    interestRate = 0;
                }
            }
        }

        public BankAccountType Type { get; set; }

        public decimal Deposit(decimal amount) {
            if (amount < 0)
                amount = 0;
            Balance += amount;
            return amount;
        }

        public decimal Withdraw(decimal amount) {
            if (amount > Balance && Type==BankAccountType.Savings) {
                throw new OperationNotSupportedException();
            }
            Balance -= amount;
            return amount;
        }

        public decimal CalculateInterest() {
            if (Type != BankAccountType.Savings) {
                throw new OperationNotSupportedException();
            }
            return 10;
        }
    }
}
