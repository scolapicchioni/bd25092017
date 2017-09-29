using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public class Bank 
    {
        //new Bank() // default constructor
        public Bank() 
        {
            accounts = new BankAccount[10];
            _name = "";
        }

        //new Bank("Rabobank");
        public Bank(string bankName) {
            accounts = new BankAccount[10];
            _name = bankName;
        }

        private int lastBankAccountNumber;// default == 0
        private string _name; //default == null

        private BankAccount[] accounts;// null
        int count; // = 0;

        public string Name 
        {
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }

        public BankAccount OpenAccount() 
        {
            //lastBankAccountNumber = lastBankAccountNumber + 1;
            //BankAccount b1 = new BankAccount();
            //b1.AccountNumber = _name + lastBankAccountNumber;
            BankAccount b1 = new BankAccount(_name + ++lastBankAccountNumber);
            //b1.AccountNumber = _name + ++lastBankAccountNumber;
            accounts[count++] = b1;
            return b1;
        }

        //decimal total = bank.GetTotalSaldo();
        public decimal GetTotalSaldo() {
            decimal total = 0;
            for (int i = 0; i < count; i++) {
                total += accounts[i].Saldo;
            }
            return total;
        }

        public BankAccount GetBankAccountByNumber(string accountNumber) {
            BankAccount account = null;
            for (int i = 0; i < count; i++) {
                if (accountNumber == accounts[i].AccountNumber) {
                    account = accounts[i];
                    break;
                }
            }
            return account;
        }
    }
}
