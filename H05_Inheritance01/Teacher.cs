using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance01 {
    public class Teacher : Person {
        public Teacher() : base("") {

        }
        public decimal Salary { get; set; }
    }
}
