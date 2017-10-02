using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO05 {
    public class TechSupport {
        public void CopyContacts(Phone source, Phone target) {
            for (int i = 0; i < source.Contacts.Length; i++) {
                if(source.Contacts[i]!=null)
                    target.Contacts[i] = new Contact() {
                        Name = source.Contacts[i].Name,
                        PhoneNumber = source.Contacts[i].PhoneNumber
                    };
            }
        }
    }
}
