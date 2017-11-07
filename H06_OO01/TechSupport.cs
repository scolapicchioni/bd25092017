using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class TechSupport
    {
        public void CopyContacts(Phone source, Phone target) {
            PhoneBook 
                pb_source = source.Apps.FirstOrDefault<PhoneBook>(), 
                pb_target = target.Apps.FirstOrDefault<PhoneBook>();
            
            for (int i = 0; i < pb_source.Contacts.Count; i++) {
                pb_target.Contacts.Add(pb_source.Contacts[i].Name, pb_source.Contacts[i].PhoneNumber);
            }
        }
    }
}
