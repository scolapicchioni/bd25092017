using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class PhoneBook : App
    {
        public Collection<Contact> Contacts { get; } = new Collection<Contact>();

        public override void Start() {
            
        }
    }
}
