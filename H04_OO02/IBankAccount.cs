using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public interface IBankAccount {
        string AccountNumber { get; }
        decimal Saldo { get; }
        decimal Deposit(decimal amount);
        decimal Withdraw(decimal amount);

    }
}
