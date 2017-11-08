using System;
using System.Collections.Generic;
using System.Text;

namespace H07_OO02.Logic {
    public class PhoneBook : App
    {
        public ContactsCollection Contacts { get; } = new ContactsCollection();

        public override void Start() {
            
        }
    }
}
