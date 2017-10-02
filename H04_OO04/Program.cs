using System;
using System.IO;

namespace H04_OO04 {
    class Program {
        static void Main(string[] args) {
            Student[] students = new Student[3];
            Teacher[] teachers = new Teacher[3];
            School school = new School();
            for (int i = 0; i < teachers.Length; i++) {
                Console.Write("Teacher name: ");
                string name = Console.ReadLine();
                Console.Write("Teacher salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.Write("Course name: ");
                string coursename = Console.ReadLine();

                Course c = school.GetCourse(coursename); //new Course(coursename);
                Teacher t = new Teacher(name, salary, c);

                teachers[i] = t;
            }

            for (int i = 0; i < students.Length; i++) {
                Console.Write("Student name: ");
                string name = Console.ReadLine();
                Console.Write("Students Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Course name: ");
                string coursename = Console.ReadLine();

                Course c = school.GetCourse(coursename);
                Student s = new Student(name, id, c);

                students[i] = s;
            }

            StreamWriter sw = new StreamWriter(@"C:\temp\studentteachers.txt");
            Console.WriteLine("****TEACHERS*****");
            for (int i = 0; i < teachers.Length; i++) {
                sw.WriteLine($"{teachers[i].Name} {teachers[i].Salary} {teachers[i].CurrentlyTeachingCourse.Name}");
            }
            Console.WriteLine("****STUDENTS*****");
            for (int i = 0; i < students.Length; i++) {
                sw.WriteLine($"{students[i].Name} {students[i].StudentId} {students[i].CurrentlyFollowingCourse.Name}");
            }
            sw.Dispose();

            Console.ReadLine();
        }
    }
}
