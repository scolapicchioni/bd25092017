using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H05_Inheritance01 {
    public class School {
        private Course[] courses = new Course[10];
        private int coursesCount = 0;

        private Teacher[] teachers = new Teacher[10];
        private int teachersCount = 0;

        private Student[] students = new Student[10];
        private int studentsCount = 0;

        public Course GetCourse(string name) {
            Course course = null;
            for (int i = 0; i < coursesCount; i++) {
                if (courses[i].Name == name) {
                    course = courses[i];
                    return course;
                }
            }
            course = new Course() { Name = name };
            return course;
        }

        public void Print(Student s) {
            Console.WriteLine(s.Name);
        }

        public void Print(Teacher s) {
            Console.WriteLine(s.Name);
        }

        public Person Add(string name, decimal Salary) {
            return new Teacher() { Name = name, Salary = Salary };
        }

        public Person Add(string name, int studentId) {
            return new Student() { Name = name, StudentId = studentId };
        }
    }
}
