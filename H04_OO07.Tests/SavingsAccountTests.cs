using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H04_OO07.Tests
{
    public class SavingsAccountTests
    {
        [TestMethod]
        public void GivenNewBankAccountWithATypeOfSavings_WhenInterestRateIsSetBetweenTheRange_ThenInterestRateShouldBeSetWithTheInitialValue() {
            //GivenNewBankAccount
            SavingsAccount b = new SavingsAccount();
            
            //WhenAccountNumberIsSet
            b.InterestRate = 10.0;
            //ThenAccountNumberShouldBeSetWithTheInitialValue
            Assert.AreEqual(10.0, b.InterestRate);
        }

        [DataTestMethod]
        [DataRow(-21.0)]
        [DataRow(21.0)]
        public void GivenNewBankAccountWithATypeOfSavings_WhenInterestRateIsSetNotBetweenTheRange_ThenAnExceptionShouldBeThrown(double rate) {
            //GivenNewBankAccount
            SavingsAccount b = new SavingsAccount();

            //WhenInterestRateIsSetNotBetweenTheRange
            //ThenAnExceptionShouldBeThrown
            Assert.ThrowsException<ArgumentOutOfRangeException>(
                () => b.InterestRate = rate
            );
        }

        [TestMethod]
        public void GivenNewBankAccountWithTypeSavings_WhenWithdrawingMoreThanTheBalance_ThenAnExceptionShouldBeThrown() {

            //GivenNewBankAccount
            SavingsAccount b = new SavingsAccount();

            //ThenAnExceptionShouldBeThrown
            Assert.ThrowsException<OperationNotSupportedException>(
                //WhenWithdrawingMoreThanTheBalance
                () => b.Withdraw(b.Balance + 1)
            );

        }

    }
}
