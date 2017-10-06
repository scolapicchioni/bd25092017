using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance01 {
    public class Student : Person {
        public Student() : base("") {
            Console.WriteLine("New Student here");
        }

        public Student(string name) : base(name) {
            Console.WriteLine($"New Student with a name of {name} here");
        }
        public int StudentId { get; set;  }
        
    }
}
