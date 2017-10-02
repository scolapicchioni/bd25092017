using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO05 {
    public class Phone {
        //public Contact[] Contacts { get; set; } // = new Contact[10];

        private Contact[] contacts;
        public int ContactsCount { get; private set; } // = 0

        public Phone() {
            contacts = new Contact[10];
        }

        public void AddContact(string name, string phoneNumber) {
            Contact contact = new Contact() {
                Name = name, PhoneNumber = phoneNumber
            };
            contacts[ContactsCount++] = contact;
        }

        //Contact sourceContact = source.GetContactAt(i);
        public Contact GetContactAt(int index) {
            if(index>=ContactsCount)
                throw new IndexOutOfRangeException($"index cannot be greater than {ContactsCount}"); 
            return contacts[index];
        }
    }
}
