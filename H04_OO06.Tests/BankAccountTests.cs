using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace H04_OO06.Tests
{
    [TestClass]
    public class BankAccountTests {
        [TestMethod]
        public void GivenNewBankAccountThenBalanceIsZero() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //ThenBalanceIsZero
            Assert.AreEqual(0, b.Balance);
        }

        [TestMethod]
        public void GivenNewBankAccount_WhenAccountNumberIsSet_ThenAccountNumberShouldBeSetWithTheInitialValue() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WhenAccountNumberIsSet
            b.AccountNumber = "abcd";
            //ThenAccountNumberShouldBeSetWithTheInitialValue
            Assert.AreEqual("abcd", b.AccountNumber);
        }

        [TestMethod]
        public void GivenNewBankAccountWithATypeOfSavings_WhenInterestRateIsSetBetweenTheRange_ThenInterestRateShouldBeSetWithTheInitialValue() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WithATypeOfSavings
            b.Type = BankAccountType.Savings;
            //WhenAccountNumberIsSet
            b.InterestRate = 10.0;
            //ThenAccountNumberShouldBeSetWithTheInitialValue
            Assert.AreEqual(10.0, b.InterestRate);
        }

        [TestMethod]
        public void GivenNewBankAccountWithATypeOfCheckings_WhenInterestRateIsSetBetweenTheRange_ThenInterestRateShouldBeSetWithTheInitialValue() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WithATypeOfCheckings
            b.Type = BankAccountType.Checkings;
            //WhenInterestRateIsSet
            b.InterestRate = 10.0;
            //ThenInterestRateShouldRemain0
            Assert.AreEqual(0, b.InterestRate);
        }

        [DataTestMethod]
        [DataRow(-21.0)]
        [DataRow(21.0)]
        public void GivenNewBankAccountWithATypeOfSavings_WhenInterestRateIsSetNotBetweenTheRange_ThenAnExceptionShouldBeThrown(double rate) {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WithATypeOfSavings
            b.Type = BankAccountType.Savings;

            //WhenInterestRateIsSetNotBetweenTheRange
            //ThenAnExceptionShouldBeThrown
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => b.InterestRate = rate
            );
        }

        [DataTestMethod]
        [DataRow(BankAccountType.Checkings)]
        [DataRow(BankAccountType.Savings)]
        public void GivenNewBankAccount_WhenAccountTypeIsSet_ThenAccountTypeShouldBeTheInitialValue(BankAccountType type) {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WhenAccountTypeIsSet
            b.Type = type;
            //ThenAccountTypeShouldBeTheInitialValue
            //ThenAccountNumberShouldBeSetWithTheInitialValue
            Assert.AreEqual(type, b.Type);
        }


        [DataTestMethod]
        [DataRow(20, 20)]
        [DataRow(-20, 0)]
        public void GivenANewBankAccount_WhenDepositingAnAmount_ThenTheBalanceShouldIncreaseAccordingly(decimal amount, decimal expected) {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            decimal previousBalance = b.Balance;
            //WhenDepositingAnAmount
            b.Deposit(amount);
            //ThenTheBalanceShouldIncreaseAccordingly
            Assert.AreEqual(previousBalance + expected, b.Balance);
        }

        [DataTestMethod]
        [DataRow(20, 20)]
        [DataRow(-20, 0)]
        public void GivenANewBankAccount_WhenDepositingAnAmount_ThenTheReturnValueShouldBeAnExpectedValue(decimal amount, decimal expected) {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            decimal previousBalance = b.Balance;
            //WhenDepositingAnAmount
            decimal returnValue = b.Deposit(amount);
            //ThenTheBalanceShouldIncreaseAccordingly
            Assert.AreEqual(expected, returnValue);
        }

        [TestMethod]
        public void GivenNewBankAccountWithTypeSavings_WhenWithdrawingMoreThanTheBalance_ThenAnExceptionShouldBeThrown() {
            //saving may not be negative

            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WithTypeSavings
            b.Type = BankAccountType.Savings;

            //ThenAnExceptionShouldBeThrown
            Assert.ThrowsException<OperationNotSupportedException>(
                //WhenWithdrawingMoreThanTheBalance
                () => b.Withdraw(b.Balance + 1)
            );

        }

        [TestMethod]
        public void GivenNewBankAccountWithTypeCheckings_WhenWithdrawingMoreThanTheBalance_ThenTheBalanceShouldBeNegative() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //WithTypeSavings
            b.Type = BankAccountType.Checkings;

            //WhenWithdrawingMoreThanTheBalance
            b.Withdraw(b.Balance + 1);

            //ThenTheBalanceShouldBeNegative
            Assert.IsTrue(b.Balance < 0);
        }


        [TestMethod]
        public void GivenNewBankAccountAndABalanceOf100_WhenWithdrawingLessThanTheBalance_ThenTheBalanceShouldDecrease() {
            //GivenNewBankAccount
            BankAccount b = new BankAccount();
            //AndABalanceOf100
            b.Deposit(100);

            //WhenWithdrawingLessThanTheBalance
            b.Withdraw(40);

            //ThenTheBalanceShouldChange
            Assert.AreEqual(60, b.Balance);
        }

    }
}
