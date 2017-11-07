using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class PhoneBook : App
    {
        public ContactsCollection Contacts { get; } = new ContactsCollection();

        public override void Start() {
            
        }
    }
}
