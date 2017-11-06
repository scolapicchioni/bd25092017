using System;
using System.Collections.Generic;
using System.Text;

namespace H04_OO07
{
    public class SavingsAccount : BankAccount {

        private double interestRate;
        public double InterestRate {
            get {
                return interestRate;
            }
            set {
                if (value < -20.0 || value > 20.0)
                    throw new ArgumentOutOfRangeException();
                interestRate = value;
            }
        }

        public override decimal Withdraw(decimal amount) {
            if (amount > Balance) {
                throw new OperationNotSupportedException();
            }
            return base.Withdraw(amount);
            //if (amount < 0)
            //    amount = 0;
            //Balance -= amount;
            //return amount;
        }

        public decimal CalculateInterest() {
            return 10;
        }
    }
}
