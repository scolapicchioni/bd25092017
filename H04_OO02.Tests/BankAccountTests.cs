using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H04_OO02.Tests {
    [TestClass]
    public class BankAccountTest {
        [TestMethod]
        public void WhenCreatedSaldoShouldBe0() {
            //Arrange
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            //Act
            //Assert
            Assert.AreEqual(0, b1.Saldo);

            //Given
            //When
            //Then
        }

        [TestMethod]
        public void AccountNumberShouldBeTheEqualToTheFirst20Letters() {
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            Assert.AreEqual("12345678901234567890", b1.AccountNumber);
        }

        [TestMethod]
        public void AccountNumberShouldNotBeLongerThan20() {
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            Assert.AreEqual(20, b1.AccountNumber.Length);
        }

        [TestMethod]
        public void WhenCreatedAccountNumberShouldNotBeLongerThan20() {
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            Assert.AreEqual(20, b1.AccountNumber.Length);
        }

        [TestMethod]
        public void WhenDepositingANegativeAmountThenDepositShouldReturn0() {
            //Given a new BankAccount
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            //When depositing a negative amount
            decimal deposited = b1.Deposit(-100);
            //Then the returned value should be 0
            Assert.AreEqual(0, deposited);
        }

        [TestMethod]
        public void WhenDepositingANegativeAmountThenSaldoShouldBeUnchanged() {
            //Given a new BankAccount
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            decimal previousSaldo = b1.Saldo;
            //When depositing a negative amount
            decimal deposited = b1.Deposit(-100);
            //Then the returned value should be 0
            Assert.AreEqual(previousSaldo,b1.Saldo);
        }

        [TestMethod]
        public void WhenDepositingAPositiveAmountThenDepositShouldReturnTheDepositedAmount() {
            //Given a new BankAccount
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            //When depositing a negative amount
            decimal amountToDeposit = 100;
            decimal deposited = b1.Deposit(amountToDeposit);
            //Then the returned value should be 0
            Assert.AreEqual(amountToDeposit, deposited);
        }

        [TestMethod]
        public void WhenDepositingAPositiveAmountThenSaldoShouldBeIncrementedByTheDepositedAmount() {
            //Given a new BankAccount
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            decimal previousSaldo = b1.Saldo;
            decimal toDeposit = 100;
            //When depositing a negative amount
            decimal deposited = b1.Deposit(toDeposit);
            //Then the returned value should be 0
            Assert.AreEqual(previousSaldo + toDeposit, b1.Saldo);
        }

        [TestMethod]
        public void GivenAnAccountWithSaldoOf100_WhenWithdrawing30_ThenSaldoShouldBe70() {
            //Given a BankAccount
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            //with a saldo of 100
            decimal initialSaldo = 100;
            b1.Deposit(initialSaldo);
            decimal previousSaldo = b1.Saldo;
            decimal toWithdraw = 30;
            //When depositing a negative amount
            decimal withdrawn = b1.Withdraw(toWithdraw);
            //Then the returned value should be 70
            Assert.AreEqual(previousSaldo - toWithdraw, b1.Saldo);
        }

        [TestMethod]
        public void GivenAnAccountWithSaldoOf100_WhenWithdrawing2000_ThenSaldoShouldBe0() {
            //Given a BankAccount
            BankAccount b1 = new BankAccount("123456789012345678901234567890");
            //with a saldo of 100
            decimal initialSaldo = 100;
            b1.Deposit(initialSaldo);
            decimal previousSaldo = b1.Saldo;
            decimal toWithdraw = 2000;
            //When depositing a negative amount
            decimal withdrawn = b1.Withdraw(toWithdraw);
            //Then the returned value should be 0
            Assert.AreEqual(0, b1.Saldo);
        }

        
    }
}
