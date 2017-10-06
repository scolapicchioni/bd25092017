using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H05_LabInheritance01.Tests {
    [TestClass]
    public class GoldCardTests {
        [TestMethod]
        public void GivenANewGoldCard_WhenCreated_ThenTheCardRecordsCustomerNameAddressCityCustomerIdCredit() {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            decimal discount = 1;
            GoldCard card = new GoldCard(cardId, name, address, city, credit, discount);
            Assert.AreEqual(cardId, card.Id);
            Assert.AreEqual(name, card.CustomerName);
            Assert.AreEqual(address, card.CustomerAddress);
            Assert.AreEqual(city, card.CustomerCity);
            Assert.AreEqual(credit, card.Credit);
            Assert.AreEqual(discount, card.Discount);
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(31)]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GivenGoldCard_WhenConstructingWithDiscountOutOfRange_ThenShouldThrow(int discount) {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                GoldCard card = new GoldCard(cardId, name, address, city, credit, (decimal)discount);
            });
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(31)]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GivenGoldCard_WhenSettingDiscountOutOfRange_ThenShouldThrow(int discount) {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            
            GoldCard card = new GoldCard(cardId, name, address, city, credit, 10);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => {
                card.Discount = (decimal)discount;
            });
        }

        [TestMethod]
        public void GoldCardMayHaveNegativeCredit() {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            decimal toPay = credit + 1000;
            decimal discount = 10;
            GoldCard card = new GoldCard(cardId, name, address, city, credit, discount);

            card.Pay(toPay);
            Assert.IsTrue(card.Credit < 0);
        }

        [TestMethod]
        public void GoldCard_WhenPaying_DiscountIsConsidered() {
            int cardId = 1;
            string name = "Customer1";
            string address = "Address1";
            string city = "City1";
            decimal credit = 100;
            decimal toPay = 10;
            decimal discount = 10;
            decimal expectedToPay = toPay - (toPay * discount / 100);
            decimal expectedCredit = credit - expectedToPay;
            GoldCard card = new GoldCard(cardId, name, address, city, credit, discount);

            card.Pay(toPay);
            Assert.AreEqual(expectedCredit,card.Credit);
        }
    }
}
