using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO05.Tests {
    [TestClass]
    public class TechSupportTests {
        [TestMethod]
        public void GivenAPhoneWith5ContactsAndAPhoneWithNoContactsAndATechSupport_WhenCopyinTheContactsFromPhone1ToPhone2_ThenTheContactsInPhone2ShouldBeTheSameOfPhone1() {
            //GivenAPhone
            Phone sourcePhone = new Phone();
            //With5Contacts
            Contact c1 = new Contact();
            c1.Name = "C1";
            c1.PhoneNumber = "PN1";

            Contact c2 = new Contact() { Name = "C2", PhoneNumber = "PN2" };

            sourcePhone.Contacts[0] = c1;
            sourcePhone.Contacts[1] = c2;
            sourcePhone.Contacts[2] = new Contact() { Name = "C3", PhoneNumber = "PN3" };
            sourcePhone.Contacts[3] = new Contact() { Name = "C4", PhoneNumber = "PN4" };
            sourcePhone.Contacts[4] = new Contact() { Name = "C5", PhoneNumber = "PN5" };

            //AndAPhone
            Phone targetPhone = new Phone();
            //WithNoContacts
            //AndATechSupport
            TechSupport techSupport = new TechSupport();

            //WhenCopyingTheContactsFromPhone1ToPhone2
            techSupport.CopyContacts(sourcePhone, targetPhone);

            //ThenTheContactsInPhone2ShouldBeTheSameOfPhone1
            for (int i = 0; i < 5; i++) {
                Assert.AreEqual(sourcePhone.Contacts[i].Name, targetPhone.Contacts[i].Name);
                Assert.AreEqual(sourcePhone.Contacts[i].PhoneNumber, targetPhone.Contacts[i].PhoneNumber);
            }
        }
    }
}
