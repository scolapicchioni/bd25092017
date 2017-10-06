using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance02 {
    public class GoldBankAccount : BankAccount {
        public GoldBankAccount(string accountNumber): base(accountNumber) {

        }

        public override decimal Withdraw(decimal amount) {
            if (amount < 0)
                amount = 0;
            _saldo -= amount;
            return amount;
        }
        
    }
}
