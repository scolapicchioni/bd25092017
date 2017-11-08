using System;
using System.Collections.Generic;
using System.Text;

namespace H07_OO02.Logic {
    public delegate bool ContactChecker(Contact item);
    public class ContactsCollection : Collection<Contact>
    {
        public void Add(string name, string phoneNumber) {
            Contact contact = new Contact();
            contact.Name = name;
            contact.PhoneNumber = phoneNumber;
            Add(contact);
        }

        
    }
}
