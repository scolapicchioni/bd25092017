using System;
using System.Collections.Generic;
using System.Text;

namespace H08_Events02
{
    public class IrresponsibleOwner : Owner {
        public override void UseBankAccount() {
            Account.Withdraw(100);
        }
    }
}
