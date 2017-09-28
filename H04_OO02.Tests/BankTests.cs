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
    }
}
