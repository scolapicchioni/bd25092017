using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO05 {
    public class Phone {
        public Contact[] Contacts { get; set; } // = new Contact[10];
        public Phone() {
            Contacts = new Contact[10];
        }
    }
}
