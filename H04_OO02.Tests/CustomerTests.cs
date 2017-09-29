using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02.Tests {
    [TestClass]
    public class CustomerTests {
        [TestMethod]
        public void GivenNewCustomer_ThenCustomerHasNullAccount() 
        {
            //Given new Customer
            Customer c = new Customer();
            //Then c has null Account
            Assert.IsNull(c.Account);
        }

        [TestMethod]
        public void GivenNewCustomerAndANewAccount_WhenAssignedAnAccount_ThenCustomerShouldHaveAnAccount() {
            //Given new Customer
            Customer c = new Customer();
            //And a new Account
            BankAccount b = new BankAccount("Rabo1234");
            //When Assigned The Account
            c.Account = b;
            //Then Customer Should Have The Same Account
            Assert.AreEqual(c.Account, b);
        }

        [TestMethod]
        public void GivenNewCustomerAndABankAccountWithASaldoOf100_WhenAssignedTheAccount_ThenCustomerShouldHaveAnAccountWithASaldoOf100() {
            //Given new Customer
            Customer c = new Customer();
            //And A BankAccount With A Saldo Of 100
            BankAccount b = new BankAccount("");
            b.Deposit(100);
            //When Assigned The Account
            c.Account = b;
            //Then Customer Should Have An Account With A Saldo Of 100
            Assert.AreEqual(c.Account.Saldo, b.Saldo);
        }
    }
}
