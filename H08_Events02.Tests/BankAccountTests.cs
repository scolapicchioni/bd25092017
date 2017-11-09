using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H08_Events02.Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void GivenANewBankAccount_WhenWithdrawing_ThenTheSaldoDecreasedEventShouldBeRaisedWithTheNewSaldo()
        {
            //GivenANewBankAccount
            BankAccount bankAccount = new BankAccount("BA123");

            BankAccount sourceAccount = null;
            decimal actualSaldo = 10;

            bankAccount.SaldoDecreased += (source, newSaldo) => {
                sourceAccount = source;
                actualSaldo = newSaldo;  
            };

            //WhenWithdrawing
            bankAccount.Withdraw(1);

            //ThenTheSaldoDecreasedEventShouldBeRaisedWithTheNewSaldo
            Assert.AreEqual(bankAccount, sourceAccount);
            Assert.AreEqual(0, actualSaldo);


        }

        [TestMethod]
        public void GivenANewBankAccount_WhenWithdrawing_ThenTheSaldoChangedEventShouldBeRaisedWithTheNewSaldo() {
            //GivenANewBankAccount
            BankAccount bankAccount = new BankAccount("BA123");

            BankAccount sourceAccount = null;
            decimal actualSaldo = 10;

            bankAccount.SaldoChanged += (source, newSaldo) => {
                sourceAccount = source;
                actualSaldo = newSaldo;
            };

            //WhenWithdrawing
            bankAccount.Withdraw(1);

            //ThenTheSaldoChangedEventShouldBeRaisedWithTheNewSaldo
            Assert.AreEqual(bankAccount, sourceAccount);
            Assert.AreEqual(0, actualSaldo);

        }

        [TestMethod]
        public void GivenANewBankAccount_WhenDepositing_ThenTheSaldoChangedEventShouldBeRaisedWithTheNewSaldo() {
            //GivenANewBankAccount
            BankAccount bankAccount = new BankAccount("BA123");

            BankAccount sourceAccount = null;
            decimal actualSaldo = 10;

            bankAccount.SaldoChanged += (source, newSaldo) => {
                sourceAccount = source;
                actualSaldo = newSaldo;
            };

            //WhenWithdrawing
            bankAccount.Deposit(1);

            //ThenTheSaldoChangedEventShouldBeRaisedWithTheNewSaldo
            Assert.AreEqual(bankAccount, sourceAccount);
            Assert.AreEqual(1, actualSaldo);

        }
    }
}
