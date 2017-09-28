using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public class Bank {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public BankAccount OpenAccount() {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = _name;
            return b1;
        }
    }
}
