using System;
using System.Collections.Generic;
using System.Text;

namespace H08_Events02
{
    public abstract class Owner
    {
        public string Name { get; set; }
        public BankAccount Account { get; set; }

        public abstract void UseBankAccount();
    }
}
