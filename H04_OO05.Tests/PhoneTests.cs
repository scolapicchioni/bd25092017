using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO05.Tests {
    [TestClass]
    public class PhoneTests {
        [TestMethod]
        public void GivenANewPhone_ThenContactsCountShouldNot0() {
            //GivenANewPhone
            Phone phone = new Phone();
            //ThenContactsShouldNotBeNull
            Assert.AreEqual(0, phone.ContactsCount);
        }

        [TestMethod]
        public void GivenANewPhone_WhenAddingAContact_ThenContactNumberShouldIncrease() {
            //GivenANewPhone
            Phone phone = new Phone();
            int prevCount = phone.ContactsCount; //0
            //WhenAddingAContact
            phone.AddContact("Mario", "12345");
            //ThenContactNumberShouldIncrease
            Assert.AreEqual(prevCount + 1, phone.ContactsCount);
        }

        [TestMethod]
        public void GivenANewPhone_WhenAddingAContact_ThenContactShouldBeAtPosition0() {
            //GivenANewPhone
            Phone phone = new Phone();
            
            phone.AddContact("Mario", "12345");

            Contact c = phone.GetContactAt(0);

            Assert.AreEqual("Mario", c.Name);
            Assert.AreEqual("12345", c.PhoneNumber);
        }
    }
}
