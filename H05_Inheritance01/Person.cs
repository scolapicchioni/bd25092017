using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance01 {
    public class Person {
        //public Person() {
        //    Console.WriteLine("A Person is born");
        //}
        public Person(string name) {
            Console.WriteLine($"A Person with a name of {name} is born");
            Name = name;
        }

        public string Name { get; set; }
        public int Gender { get; set; }
        public Course Course { get; set; }
    }
}
