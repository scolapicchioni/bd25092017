using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public class Bank 
    {
        private int lastBankAccountNumber = 0;// default == 0
        private string _name;

        private BankAccount[] accounts = new BankAccount[10];// null
        int count = 0;

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
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = _name + ++lastBankAccountNumber;
            accounts[count++] = b1;
            return b1;
        }

        //decimal total = bank.GetTotalSaldo();
        public decimal GetTotalSaldo() {
            decimal total = 0;
            //foreach (BankAccount account in accounts) {
            //    if(account!=null)
            //        total += account.Saldo;
            //}
            for (int i = 0; i < count; i++) {
                total += accounts[i].Saldo;
            }
            return total;
        }
    }
}
