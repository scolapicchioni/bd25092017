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

            sourcePhone.AddContact(c1.Name,c1.PhoneNumber);
            sourcePhone.AddContact(c2.Name,c2.PhoneNumber);
            sourcePhone.AddContact("C3", "PN3");
            sourcePhone.AddContact("C4", "PN4");
            sourcePhone.AddContact("C5", "PN5");

            //AndAPhone
            Phone targetPhone = new Phone();
            //WithNoContacts
            //AndATechSupport
            TechSupport techSupport = new TechSupport();

            //WhenCopyingTheContactsFromPhone1ToPhone2
            techSupport.CopyContacts(sourcePhone, targetPhone);

            //ThenTheContactsInPhone2ShouldBeTheSameOfPhone1
            for (int i = 0; i < sourcePhone.ContactsCount; i++) {
                Assert.AreEqual(sourcePhone.GetContactAt(i).Name, targetPhone.GetContactAt(i).Name);
                Assert.AreEqual(sourcePhone.GetContactAt(i).PhoneNumber, targetPhone.GetContactAt(i).PhoneNumber);
            }
        }
    }
}
