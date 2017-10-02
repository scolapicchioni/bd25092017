using System;

namespace H04_OO04 {
    class Program {
        static void Main(string[] args) {
            Student[] students = new Student[10];
            Teacher[] teachers = new Teacher[10];

            for (int i = 0; i < teachers.Length; i++) {
                Console.Write("Teacher name: ");
                string name = Console.ReadLine();
                Console.Write("Teacher salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.Write("Course name: ");
                string coursename = Console.ReadLine();

                Course c = new Course(coursename);
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

                Course c = new Course(coursename);
                Student s = new Student(name, id, c);

                students[i] = s;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
