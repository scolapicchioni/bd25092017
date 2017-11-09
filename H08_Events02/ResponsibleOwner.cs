using System;
using System.Collections.Generic;
using System.Text;

namespace H08_Events02
{
    public class ResponsibleOwner : Owner {
        public override void UseBankAccount() {
            Account.Deposit(100);
        }

        public void Panic(BankAccount account, decimal newSaldo) {
            Account.Deposit(123);
        }
    }
}
