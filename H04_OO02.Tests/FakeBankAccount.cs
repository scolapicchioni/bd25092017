using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02.Tests {
    class FakeBankAccount : IBankAccount {
        public string AccountNumber => throw new NotImplementedException();

        public decimal Saldo => throw new NotImplementedException();

        public bool depositInvoked, withdrawInvoked;

        public decimal Deposit(decimal amount) {
            depositInvoked = true;
            return 0;
        }

        public decimal Withdraw(decimal amount) {
            withdrawInvoked = true;
            return 0;
        }
    }
}
