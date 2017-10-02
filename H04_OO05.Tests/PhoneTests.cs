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
        public void GivenANewPhone_ThenContactsShouldNotBeNull() {
            //GivenANewPhone
            Phone phone = new Phone();
            //ThenContactsShouldNotBeNull
            Assert.IsNotNull(phone.Contacts);
        }

        [TestMethod]
        public void GivenANewPhone_WhenAddingAContact_ThenContactNumberShouldIncrease() {
            //GivenANewPhone
            Phone phone = new Phone();
            int prevCount = phone.ContactsCount;
            phone.AddContact("Mario", "12345");
            Assert.AreEqual(prevCount + 1, phone.ContactsCount);
        }
    }
}
