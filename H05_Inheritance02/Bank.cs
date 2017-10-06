using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance02 {
    public class Bank {
        public string Name { get; set; }
        BankAccount[] accounts = new BankAccount[10];
        public int Count { get; private set; }
        public BankAccount OpenAccount() {
            BankAccount account = new BankAccount($"{Name}{Count + 1}");
            accounts[Count++] = account;
            return account;
        }
    }
}
