using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace H04_OO07.Tests {
    [TestClass]
    public class BankAccountTests {
        [TestMethod]
        public void GivenNewBankAccount_ThenBalanceIsZero() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount("abc");
            //ThenBalanceIsZero
            Assert.AreEqual(0, b.Balance);
        }

        [TestMethod]
        public void GivenNewBankAccount_WhenAccountNumberIsSet_ThenAccountNumberShouldBeSetWithTheInitialValue() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount("abcd");
            //ThenAccountNumberShouldBeSetWithTheInitialValue
            Assert.AreEqual("abcd", b.AccountNumber);
        }

        [DataTestMethod]
        [DataRow(20, 20)]
        [DataRow(-20, 0)]
        public void GivenANewBankAccount_WhenDepositingAnAmount_ThenTheBalanceShouldIncreaseAccordingly(int amount, int expected) {
            //GivenNewBankAccount
            BankAccount b = new BankAccount("abc");
            decimal previousBalance = b.Balance;
            //WhenDepositingAnAmount
            b.Deposit(amount);
            //ThenTheBalanceShouldIncreaseAccordingly
            Assert.AreEqual(previousBalance + expected, b.Balance);
        }

        [DataTestMethod]
        [DataRow(20, 20)]
        [DataRow(-20, 0)]
        public void GivenANewBankAccount_WhenDepositingAnAmount_ThenTheReturnValueShouldBeAnExpectedValue(int amount, int expected) {
            //GivenNewBankAccount
            BankAccount b = new BankAccount("abc");
            decimal previousBalance = b.Balance;
            //WhenDepositingAnAmount
            decimal returnValue = b.Deposit(amount);
            //ThenTheBalanceShouldIncreaseAccordingly
            Assert.AreEqual(expected, returnValue);
        }

        [TestMethod]
        public void GivenNewBankAccount_WhenWithdrawingMoreThanTheBalance_ThenTheBalanceShouldBeNegative() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount("abc");
            
            //WhenWithdrawingMoreThanTheBalance
            b.Withdraw(b.Balance + 1);

            //ThenTheBalanceShouldBeNegative
            Assert.IsTrue(b.Balance < 0);
        }


        [TestMethod]
        public void GivenNewBankAccountAndABalanceOf100_WhenWithdrawingLessThanTheBalance_ThenTheBalanceShouldDecrease() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount("abc");
            //AndABalanceOf100
            b.Deposit(100);

            //WhenWithdrawingLessThanTheBalance
            b.Withdraw(40);

            //ThenTheBalanceShouldChange
            Assert.AreEqual(60, b.Balance);
        }

    }
}
