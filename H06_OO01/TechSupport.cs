using System;
using System.Collections.Generic;
using System.Text;

namespace H06_OO01
{
    public class TechSupport
    {
        public void CopyContacts(Phone source, Phone target) {
            PhoneBook pb_source=null, pb_target=null;

            for (int i = 0; i < source.Apps.Count; i++) {
                App app = source.Apps[i];
                if (app is PhoneBook) {
                    pb_source = (PhoneBook)app;
                    break;
                }
            }

            for (int i = 0; i < target.Apps.Count; i++) {
                App app = target.Apps[i];
                if (app is PhoneBook) {
                    pb_target = (PhoneBook)app;
                    break;
                }
            }
            for (int i = 0; i < pb_source.Contacts.Count; i++) {
                pb_target.Contacts.Add(pb_source.Contacts[i]);
            }
            

        }
    }
}
