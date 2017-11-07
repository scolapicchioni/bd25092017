using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public delegate bool ContactChecker(Contact item);
    public class ContactsCollection : Collection<Contact>
    {
        public void Add(string name, string phoneNumber) {
            Contact contact = new Contact();
            contact.Name = name;
            contact.PhoneNumber = phoneNumber;
            Add(contact);
        }

        //public bool CheckIfPhoneNumberStartsWith06(Contact item) {
        //    return item.PhoneNumber.StartsWith("06");
        //}

         

        //Where(CheckIfPhoneNumberStartsWith06)
        //Where(CheckIfNameStartsWithA)
        //Where(Add); NO!
        public ContactsCollection Where(ContactChecker CheckStuff) {
            ContactsCollection result = new ContactsCollection();
            for (int i = 0; i < this.Count; i++) {
                if (CheckStuff(this[i])) {
                    result.Add(this[i]);
                }
            }
            return result;
        }

        ////WherePhoneNumberStartsWith06();
        //public ContactsCollection WherePhoneNumberStartsWith06() {
        //    ContactsCollection result = new ContactsCollection();
        //    for (int i = 0; i < this.Count; i++) {
        //        if (CheckIfPhoneNumberStartsWith06(this[i])) {
        //            result.Add(this[i]);
        //        }
        //    }
        //    return result;
        //}

        //public bool CheckIfNameStartsWithA(Contact item) {
        //    return item.Name.StartsWith("A");
        //}

        //public ContactsCollection WhereNameStartsWithA() {
        //    ContactsCollection result = new ContactsCollection();
        //    for (int i = 0; i < this.Count; i++) {
        //        if (CheckIfNameStartsWithA(this[i])) {
        //            result.Add(this[i]);
        //        }
        //    }
        //    return result;
        //}

        //public bool CheckIfNameLongerThan6(Contact item) {
        //    return item.Name.Length > 6;
        //}

        //public ContactsCollection WhereNameLengthGreaterThan6() {
        //    ContactsCollection result = new ContactsCollection();
        //    for (int i = 0; i < this.Count; i++) {
        //        if (CheckIfNameLongerThan6(this[i])) {
        //            result.Add(this[i]);
        //        }
        //    }
        //    return result;
        //}
    }
}
