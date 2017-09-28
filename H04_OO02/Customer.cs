using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public class Customer {
        private string _name;

        public string Name {
            get { return _name; }
            set {
                if (value.Length > 50)
                    value = value.Substring(0, 50);
                _name = value;
            }
        }

    }
}
