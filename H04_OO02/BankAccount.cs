using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public class BankAccount 
    {
        public BankAccount(string accountNumber) {
            AccountNumber = accountNumber;
        }

        private decimal _saldo; //default == 0

        //public void SetAccountNumber(string inputValue) {
        //    if (inputValue.Length > 20) {
        //        AccountNumber = inputValue.Substring(0, 20);
        //    } else {
        //        AccountNumber = inputValue;
        //    }
        //}
        //public string GetAccountNumber() {
        //    return AccountNumber;
        //}

        private string _accountNumber;

        public string AccountNumber 
        {
            //b1.AccountNumber = "aaaaaaaaaaaaaaaaaaaa";
            private set //value => "aaaaaaaaaaaaaaaaaaaa"
            {
                if (value.Length > 20) {
                    _accountNumber = value.Substring(0, 20);
                } else {
                    _accountNumber = value;
                }
            }
            //string an = b1.AccountNumber;
            get 
            {
                return _accountNumber;
            }
        }


        public decimal Saldo 
        {
            get {
                return _saldo;
            }
        }

        public decimal Deposit(decimal amount) 
        {
            if (amount < 0)
                amount = 0;
            _saldo = _saldo + amount;
            return amount;
        }
        public decimal Withdraw(decimal amount) {
            if (amount < 0)
                amount = 0;
            if (amount > _saldo)
                amount = _saldo;

            _saldo = _saldo - amount;
            return amount;
        }

    }
}
