using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H04_OO07.Tests
{
    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void GivenANewBank_AndTwoBankAccounts_WhenTransferringMoney_ThenTheBalanceOfTheAccountsShouldChange() {
            //GivenANewBank
            Bank bank = new Bank();
            //AndTwoBankAccounts
            BankAccount source = new BankAccount();
            BankAccount target = new BankAccount();

            source.Deposit(100);

            //WhenTransferringMoney
            bank.Transfer(source, target, 40);
            //ThenTheBalanceOfTheAccountsShouldChange
            Assert.AreEqual(100 - 40, source.Balance);
            Assert.AreEqual(0 + 40, target.Balance);
        }

        [TestMethod]
        public void GivenANewBank_AndTwoSavingsAccounts_WhenTransferringMoney_ThenTheBalanceOfTheAccountsShouldChange() {
            //GivenANewBank
            Bank bank = new Bank();
            //AndTwoBankAccounts
            SavingsAccount source = new SavingsAccount();
            SavingsAccount target = new SavingsAccount();

            source.Deposit(100);

            //WhenTransferringMoney
            bank.Transfer(source, target, 40);
            //ThenTheBalanceOfTheAccountsShouldChange
            Assert.AreEqual(100 - 40, source.Balance);
            Assert.AreEqual(0 + 40, target.Balance);
        }

        [TestMethod]
        public void GivenANewBank_AndTwoSavingsAccountsWithABalanceOf0_WhenTransferringMoney_ThenAnExceptionShouldBeThrown() {
            //GivenANewBank
            Bank bank = new Bank();
            //AndTwoBankAccounts
            SavingsAccount source = new SavingsAccount();
            SavingsAccount target = new SavingsAccount();

            Assert.ThrowsException<OperationNotSupportedException>(()=> {
                //WhenTransferringMoney
                bank.Transfer(source, target, 40);
            });
        }
    }
}
