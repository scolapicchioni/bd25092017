using System;
using System.Collections.Generic;
using System.Text;

namespace H04_OO07
{
    public class Bank
    {
        private BankAccount[] accounts = new BankAccount[20];
        private int count = 0;

        public int Count => count;

        //bank.GetAccount(2)
        //public BankAccount GetAccount(int index) {
        //    return accounts[index];
        //}

        public BankAccount GetAccount(int index) => accounts[index];

        //bank[2]
        //public BankAccount this[int index] {
        //    get {
        //        return accounts[index];
        //    }
        //    //bank[5] = b; 
        //    //set {
        //    //    accounts[index] = value;
        //    //}
        //}

        public BankAccount this[int index] => accounts[index];

        public BankAccount this[string accNumber] {
            get {
                BankAccount found = null;
                for (int i = 0; i < count; i++) {
                    if (accounts[i].AccountNumber == accNumber) {
                        return accounts[i];
                    }
                }
                return found;
            }
        }

        public decimal TotalBalance() {
            decimal total = 0;
            for (int i = 0; i < count; i++) {
                total += accounts[i].Balance;
            }
            return total;
        }

        //bank.Transfer(source, target, 40);
        public void Transfer(BankAccount source, BankAccount target, decimal amount) {
            source.Withdraw(amount);
            target.Deposit(amount);
        }

        //BankAccount b1 = bank.OpenAccount();
        public BankAccount OpenAccount() {
            string accNum = "B" + (count + 1).ToString("0000");
            BankAccount b = new BankAccount(accNum);
            return saveAccount(b);
        }

        public BankAccount OpenSavingsAccount() {
            string accNum = "S" + (count + 1).ToString("0000");
            BankAccount b = new SavingsAccount(accNum);
            return saveAccount(b);
        }

        private BankAccount saveAccount(BankAccount toSave) {
            accounts[count] = toSave;
            count++;
            return toSave;
        }
    }
}
