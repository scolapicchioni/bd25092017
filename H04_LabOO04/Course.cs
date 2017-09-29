using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_LabOO04 {
    public class Course {
        public Course(string name) {
            Name = name;
        }

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

    }
}
