using System;
using System.Collections.Generic;
using System.Text;

namespace H08_Events02
{
    public delegate void SaldoChangedHandler(BankAccount source, decimal newSaldo);

    public class BankAccount {

        public event SaldoChangedHandler SaldoDecreased;
        public event SaldoChangedHandler SaldoChanged;

        protected decimal _saldo;
        public string AccountNumber { get; }

        public BankAccount(string accountNumber) {
            AccountNumber = accountNumber;
        }

        public decimal Saldo {
            get { return _saldo; }
            private set {
                _saldo = value;
                if (SaldoChanged != null)
                    SaldoChanged(this, _saldo);
            }
        }

        public virtual decimal Withdraw(decimal amount) {
            if (amount < 0)
                amount = 0;
            if (amount > _saldo)
                amount = _saldo;
            Saldo -= amount;
            if (SaldoDecreased != null)
                SaldoDecreased(this, _saldo);
            return amount;
        }
        public decimal Deposit(decimal amount) {
            if (amount < 0)
                amount = 0;
            Saldo += amount;
            return amount;
        }
    }
}
