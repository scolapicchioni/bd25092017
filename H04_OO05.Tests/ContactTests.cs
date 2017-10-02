using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace H04_OO05.Tests {
    [TestClass]
    public class ContactTests {
        [TestMethod]
        public void GivenANewContact_WhenAssignedANameOfMario_ThenTheNameShouldBeMario() {
            //GivenANewContact
            Contact contact = new Contact();
            //WhenAssignedANameOfMario
            contact.Name = "Mario";
            //ThenTheNameShouldBeMario
            Assert.AreEqual("Mario", contact.Name);
        }

        [TestMethod]
        public void GivenANewContact_WhenAssignedAPhoneNumberOf12345678_ThenThePhoneNumberShouldBe12345678() {
            //GivenANewContact
            Contact contact = new Contact();
            //WhenAssignedAPhoneNumberOf12345678
            contact.PhoneNumber = "12345678";
            //ThenThePhoneNumberShouldBe12345678
            Assert.AreEqual("12345678", contact.PhoneNumber);
        }
    }
}
