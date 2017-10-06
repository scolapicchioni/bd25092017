using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance01 {
    class Program {
        static void Main(string[] args) {
            //Person p = new Person() { Name = "Simona" };
            //Print(p);

            //Student s = new Student() { Name = "Student1",StudentId =1 };

            //Teacher t = new Teacher() { Gender = 1 , Salary = 1234};

            //Print(t);
            //Print(s);

            ////Person toPrint = t;
            //Person toPrint = new Teacher() { Gender = 1, Salary = 1234 };
            //Teacher teacherToPrint = (Teacher)toPrint;
            ////teacherToPrint.Salary
            ////toPrint.Salary

            //Person[] people = new Person[10];
            //people[0] = s;
            //people[1] = t;
            //people[2] = new Student();

            //people[2].StudentId

            //Person p = new Person("Simona");
            Student s = new Student("Simona");
            Console.ReadLine();
        }

        private static void Print(Person toPrint) {
            if (toPrint is Teacher) {
                Teacher teacherToPrint = (Teacher)toPrint;
                Console.WriteLine(teacherToPrint.Salary);
            }
            
            Teacher teacherToPrint2 = toPrint as Teacher;
            if(teacherToPrint2 != null) { 
                Console.WriteLine(teacherToPrint2.Salary);
            }
            
            Console.WriteLine(toPrint.Name);
        }
    }
}
