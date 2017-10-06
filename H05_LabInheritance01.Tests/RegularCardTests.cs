using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H05_LabInheritance01.Tests {
    [TestClass]
    public class RegularCardTests {
        [TestMethod]
        public void GivenANewRegularCard_WhenCreated_ThenTheCardRecordsCustomerNameAddressCityCustomerIdCredit() {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;		
            RegularCard card = new RegularCard(cardId, name, address, city, credit);
            Assert.AreEqual(cardId, card.Id);
            Assert.AreEqual(name, card.CustomerName);
            Assert.AreEqual(address, card.CustomerAddress);
            Assert.AreEqual(city, card.CustomerCity);
            Assert.AreEqual(credit, card.Credit);
        }
        [TestMethod]
        public void GivenANewCustomer_WhenPaying__ThenAmountShouldBeSubtractedFromCredit() {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            decimal toPay = 30;
            RegularCard card = new RegularCard(cardId, name, address, city, credit);

            card.Pay(toPay);

            Assert.AreEqual(credit - toPay, card.Credit);

        }

        [TestMethod]
        public void RegularCardMayNotHaveNegativeCredit() {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            decimal toPay = credit + 1;
            RegularCard card = new RegularCard(cardId, name, address, city, credit);

            card.Pay(toPay);
            Assert.IsTrue(card.Credit >= 0);
        }
    }
}
