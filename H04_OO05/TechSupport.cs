using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO05 {
    public class TechSupport {
        public void CopyContacts(Phone source, Phone target) {
            for (int i = 0; i < source.ContactsCount; i++) {
                Contact sourceContact = source.GetContactAt(i);
                if (sourceContact != null)
                    //target.AddContact(new Contact() {
                    //    Name = sourceContact.Name,
                    //    PhoneNumber = sourceContact.PhoneNumber
                    //});
                    target.AddContact(  sourceContact.Name,
                                        sourceContact.PhoneNumber
                                    );
            }
        }
    }
}
