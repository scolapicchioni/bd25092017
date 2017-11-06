using System;
using System.Collections.Generic;
using System.Text;

namespace H04_OO07
{
    public class Bank
    {
        //bank.Transfer(source, target, 40);
        public void Transfer(BankAccount source, BankAccount target, decimal amount) {
            source.Withdraw(amount);
            target.Deposit(amount);
        }
    }
}
