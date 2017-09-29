using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02.Tests {
    [TestClass]
    public class BankTests {
        [TestMethod]
        public void GivenANewBank_WhenOpeningAnAccount_ThenTheBankAccountNumberShouldStartWithTheNameOfTheBank() {
            //Given a new Bank
            Bank bank = new Bank();
            bank.Name = "Rabobank";
            //When opening an Account
            BankAccount b1 = bank.OpenAccount();
            //Then The BankAccountNumber Should Start With The Name 
            //Of The Bank
            Assert.IsTrue(b1.AccountNumber.StartsWith(bank.Name));
        }

        [TestMethod]
        public void GivenANewBank_WhenOpeningTwoAccounts_ThenTheAccountNumberShouldBeDifferent() 
        {
            Bank bank = new Bank();
            bank.Name = "Rabobank";
            BankAccount b1 = bank.OpenAccount();
            BankAccount b2 = bank.OpenAccount();
            Assert.AreNotEqual(b1.AccountNumber, b2.AccountNumber);
        }

        [TestMethod]
        public void GivenANewBankAnd3BankAccountsWithASaldoOf100Each_WhenAskingForTotalMoney_ThenTheTotalShouldBe300() 
        {
            //GivenANewBank
            Bank bank = new Bank();
            bank.Name = "Rabobank";
            //And3BankAccounts
            BankAccount b1 = bank.OpenAccount();
            BankAccount b2 = bank.OpenAccount();
            BankAccount b3 = bank.OpenAccount();
            //WithASaldoOf100Each
            b1.Deposit(100);
            b2.Deposit(100);
            b3.Deposit(100);
            //WhenAskingForTotalMoney
            decimal expected = 300;
            decimal total = bank.GetTotalSaldo();
            //ThenTheTotalShouldBe300
            Assert.AreEqual(expected, total);
        }

        [TestMethod]
        public void HaveFunNamingThis() {
            //search for a BankAccount given an account number
            //p.s. remove using System.Linq from Bank class

        }
    }
}
