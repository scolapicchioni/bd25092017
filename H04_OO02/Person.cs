using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H04_OO02 {
    public class Person {
        string _name;
        string _address;
        int _age;

        public Person() : this("","",0) {
        }
        public Person(string name) : this(name, "",0 ){
        }
        public Person(int age) 
            : this("","",age)
        {
        }
        public Person(string name, int age) 
            : this(name, "", age)
        {
        }
        public Person(int age, string name) 
            : this(name,"",age)
        {  
        }
        public Person(string name, string address)
            : this(name,address,0)   
        {
        }
        public Person(string name, string address, int age) {
            _name = name;
            _address = address;
            _age = age;
        }

        public string SayHi() {
            return SayHi("", 1);
        }
        public string SayHi(string who) {
            return SayHi(who, 1);
        }

        public string SayHi(int times) {
            return SayHi("", times);
        }

        public string SayHi(string who, int times) {
            string message = "";
            for (int i = 0; i < times; i++) {
                message += $"Hi {who}, my name is {_name}!!";
            }
            return message;
        }
    }
}
