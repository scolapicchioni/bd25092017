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
            BankAccount source = new BankAccount("abc");
            BankAccount target = new BankAccount("abc");

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
            SavingsAccount source = new SavingsAccount("abc");
            SavingsAccount target = new SavingsAccount("abc");

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
            SavingsAccount source = new SavingsAccount("abc");
            SavingsAccount target = new SavingsAccount("abc");

            Assert.ThrowsException<OperationNotSupportedException>(()=> {
                //WhenTransferringMoney
                bank.Transfer(source, target, 40);
            });
        }

        [TestMethod]
        public void GivenANewBank_WhenOpeningAnAccount_ThenTheAccountNumberShouldBeB0001() {
            //GivenANewBank
            Bank bank = new Bank();

            //WhenOpeningAnAccount
            BankAccount b1 = bank.OpenAccount();

            //ThenTheAccountNumberShouldBeB0001
            Assert.AreEqual("B0001", b1.AccountNumber);
        }

        [TestMethod]
        public void GivenANewBank_WhenOpeningASavingsAccount_ThenTheAccountNumberShouldBeS0001() {
            //GivenANewBank
            Bank bank = new Bank();

            //WhenOpeningASavingsAccount
            BankAccount b1 = bank.OpenSavingsAccount();

            //ThenTheAccountNumberShouldBeS0001
            Assert.AreEqual("S0001", b1.AccountNumber);
        }
    }
}
