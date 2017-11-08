using System;
using System.Collections.Generic;
using System.Text;

namespace H07_OO01.ConsoleApp
{
    public class BankAccount
    {
        protected decimal _saldo;
        public string AccountNumber { get; }

        public BankAccount(string accountNumber) {
            AccountNumber = accountNumber;
        }

        public decimal Saldo {
            get { return _saldo; }
        }

        public virtual decimal Withdraw(decimal amount) {
            if (amount < 0)
                amount = 0;
            if (amount > _saldo)
                amount = _saldo;
            _saldo -= amount;
            return amount;
        }
        public decimal Deposit(decimal amount) {
            if (amount < 0)
                amount = 0;
            _saldo += amount;
            return amount;
        }

    }
}
