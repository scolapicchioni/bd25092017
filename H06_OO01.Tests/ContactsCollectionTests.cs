using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01.Tests
{
    [TestClass]
    public class ContactsCollectionTests
    {
        [TestMethod]
        public void GivenANewContactsCollection_WhenAddingAContact_ThenANewContactShouldBeFoundAtPosition0() {
            ContactsCollection cc = new ContactsCollection();
            cc.Add("name","phoneNumber");
            Assert.AreEqual("name", cc[0].Name);
            Assert.AreEqual("phoneNumber", cc[0].PhoneNumber);

            ContactsCollection people = cc.Where(checkIfPhoneNumberStrtsWith06);

            ContactsCollection people2 = cc.Where(contact => contact.PhoneNumber.StartsWith("06"));

        }

        private bool checkIfContactHasName(Contact contact) {
            return contact.Name.Length > 0;
        }

        private bool checkIfPhoneNumberStrtsWith06(Contact contact) {
            return contact.PhoneNumber.StartsWith("06");
        }
    }
}
